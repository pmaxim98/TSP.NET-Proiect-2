using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using MyPhotos.DTO;

namespace MyPhotosGUI
{
    public partial class MainForm : Form
    {
        private MultimediaDTO currentMultimedia = new MultimediaDTO();

        public MainForm()
        {
            InitializeComponent();

            listView.View = View.Details;

            listView.Columns.Add("Id");
            listView.Columns.Add("Path");
            listView.Columns.Add("Name");
            listView.Columns.Add("Created On");
            listView.Columns.Add("Added On");
            listView.Columns.Add("Modified On");

            listView.GridLines = true;

            RefreshMultimediaListView();

            listView.MouseDoubleClick += ListView_MouseDoubleClick;

            navigatingPeopleGroupBox.PictureBoxMain = pictureBoxMain;
            navigatingPeopleGroupBox.InitializePictureCrop();

            comboBoxGeneralWeather.DataSource = Enum.GetValues(typeof(WeatherDTO));
            comboBoxGeneralWeather.SelectedItem = WeatherDTO.None;

            comboBoxSearchCriteria.DataSource = Enum.GetValues(typeof(SearchCriteria));
            comboBoxSearchCriteria.SelectedItem = SearchCriteria.All;

            printDocument.OriginAtMargins = true;
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void SaveMultimedia()
        {
            MultimediaDTO multimedia = new MultimediaDTO()
            {
                Id = currentMultimedia.Id,
                Path = currentMultimedia.Path,
                Description = textBoxGeneralDescription.Text,
                Event = textBoxGeneralEvent.Text,
                Weather = (WeatherDTO) comboBoxGeneralWeather.SelectedItem,
                DateCreated = dateTimePickerDateCreated.Value,
                DateAdded = currentMultimedia.DateAdded,
                DateModified = DateTime.Now,
                Locations = navigatingLocationsGroupBox.GetLocations().ToArray(),
                People = navigatingPeopleGroupBox.GetPeople().ToArray(),
                AdditionalLabels = textBoxAdditionalLabels.Text
            };

            MyPhotosServiceClient client = new MyPhotosServiceClient();
            client.UpdateWholeMultimedia(multimedia);

            SetCurrentMultimedia(currentMultimedia.Id);
        }

        private void MultimediaToForm()
        {
            string currentMediaFullPath = currentMultimedia.Path;

            if (Extension.IsVideo(currentMediaFullPath))
            {
                pictureBoxMain.Visible = false;
                pictureBoxMain.Image = null;
                axWindowsMediaPlayer.Visible = true;
                axWindowsMediaPlayer.URL = currentMediaFullPath;
                axWindowsMediaPlayer.Ctlcontrols.stop();
            }
            else
            {
                axWindowsMediaPlayer.Visible = false;
                axWindowsMediaPlayer.URL = null;
                pictureBoxMain.Visible = true;
                pictureBoxMain.Image = Image.FromFile(currentMediaFullPath);
            }

            textBoxGeneralName.Text = Path.GetFileName(currentMediaFullPath);
            textBoxGeneralDescription.Text = currentMultimedia.Description;
            textBoxGeneralEvent.Text = currentMultimedia.Event;
            comboBoxGeneralWeather.SelectedItem = currentMultimedia.Weather;
            dateTimePickerDateCreated.Value = currentMultimedia.DateCreated;

            navigatingLocationsGroupBox.Set(currentMultimedia.Locations.ToList());

            navigatingPeopleGroupBox.Set(currentMultimedia.People.ToList());

            textBoxAdditionalLabels.Text = currentMultimedia.AdditionalLabels;
        }

        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView.SelectedItems.Count < 1)
                return;

            ListViewItem item = listView.SelectedItems[0];

            if (!item.Bounds.Contains(e.Location))
                return;

            int id = int.Parse(item.Text);

            SetCurrentMultimedia(id);
            MultimediaToForm();
        }

        private void SetCurrentMultimedia(int id)
        {
            MyPhotosServiceClient client = new MyPhotosServiceClient();
            currentMultimedia = client.GetMultimediaById(id);
        }

        private void RefreshMultimediaListView()
        {
            RefreshMultimediaListView((_) => true);
        }

        private void RefreshMultimediaListView(Func<MultimediaDTO, bool> predicate)
        {
            listView.Items.Clear();

            MyPhotosServiceClient client = new MyPhotosServiceClient();

            List<MultimediaDTO> listOfMultimedia = client.GetEveryMultimedia().ToList();

            foreach (MultimediaDTO multimedia in listOfMultimedia)
            {
                if (!File.Exists(multimedia.Path))
                {
                    MessageBox.Show(
                        "Image '" + Path.GetFileName(multimedia.Path) + "' doesn't exist anymore. It will be ignored in the app.",
                        "Inexistent image",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );

                    client.FlagMultimediaAsDeleted(multimedia.Id);
                    continue;
                }

                if (!predicate(multimedia))
                    continue;

                listView.Items.Add(new ListViewItem(new string[]
                {
                        multimedia.Id.ToString(),
                        multimedia.Path.Replace(Path.GetFileName(multimedia.Path), string.Empty),
                        Path.GetFileName(multimedia.Path),
                        multimedia.DateCreated.ToString(),
                        multimedia.DateAdded.ToString(),
                        multimedia.DateModified.ToString()
                }));
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonImportFiles_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            ImportFilesForm importFilesForm = new ImportFilesForm(openFileDialog.FileNames);

            try
            {
                importFilesForm.ShowDialog(this);
            }
            catch (Exception)
            {

            }

            RefreshMultimediaListView();
        }

        private void ImportFilesFromFolder(SearchOption searchOption)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            string[] filenames = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*", searchOption);

            ImportFilesForm importFilesForm = new ImportFilesForm(filenames);
            importFilesForm.ShowDialog(this);

            RefreshMultimediaListView();
        }

        private void buttonImportFolders_Click(object sender, EventArgs e)
        {
            ImportFilesFromFolder(SearchOption.TopDirectoryOnly);
        }

        private void buttonImportRecursive_Click(object sender, EventArgs e)
        {
            ImportFilesFromFolder(SearchOption.AllDirectories);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveMultimedia();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count < 1)
                return;

            foreach (ListViewItem item in listView.SelectedItems)
            {
                int id = int.Parse(item.Text);

                MyPhotosServiceClient client = new MyPhotosServiceClient();
                client.FlagMultimediaAsDeleted(id);
            }

            RefreshMultimediaListView();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchCriteria criteria = (SearchCriteria) comboBoxSearchCriteria.SelectedItem;

            switch (criteria)
            {
                case SearchCriteria.AdditionalLabels:
                    RefreshMultimediaListView((MultimediaDTO m) => m.AdditionalLabels.Contains(textBoxSearch.Text));
                    break;

                case SearchCriteria.Description:
                    RefreshMultimediaListView((MultimediaDTO m) => m.Description.Contains(textBoxSearch.Text));
                    break;

                case SearchCriteria.Event:
                    RefreshMultimediaListView((MultimediaDTO m) => m.Event.Contains(textBoxSearch.Text));
                    break;

                case SearchCriteria.Name:
                    RefreshMultimediaListView((MultimediaDTO m) => m.Path.Contains(textBoxSearch.Text));
                    break;

                case SearchCriteria.Weather:
                    RefreshMultimediaListView((MultimediaDTO m) => m.Weather.ToString().Contains(textBoxSearch.Text));
                    break;

                case SearchCriteria.LocationScenery:
                    RefreshMultimediaListView((MultimediaDTO m) => m.Locations.Any(l => l.Scenery.Contains(textBoxSearch.Text)));
                    break;

                case SearchCriteria.LocationName:
                    RefreshMultimediaListView((MultimediaDTO m) => m.Locations.Any(l => l.Name.Contains(textBoxSearch.Text)));
                    break;

                case SearchCriteria.LocationZipCode:
                    RefreshMultimediaListView((MultimediaDTO m) => m.Locations.Any(l => l.ZipCode.Contains(textBoxSearch.Text)));
                    break;

                case SearchCriteria.PersonFirstName:
                    RefreshMultimediaListView((MultimediaDTO m) => m.People.Any(p => p.FirstName.Contains(textBoxSearch.Text)));
                    break;

                case SearchCriteria.PersonLastName:
                    RefreshMultimediaListView((MultimediaDTO m) => m.People.Any(p => p.LastName.Contains(textBoxSearch.Text)));
                    break;

                case SearchCriteria.PersonAge:
                    RefreshMultimediaListView((MultimediaDTO m) => m.People.Any(p => p.Age.ToString().Contains(textBoxSearch.Text)));
                    break;

                default:
                    RefreshMultimediaListView();
                    break;
            }
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Image.FromFile(currentMultimedia.Path), 0, 0);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printDialog = new PrintPreviewDialog();

            printDialog.Document = printDocument;
 
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }
    }
}
