using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using MyPhotos.DTO;

namespace MyPhotosGUI
{
    public partial class ImportFilesForm : Form
    {
        private List<string> filenames;

        public ImportFilesForm(string[] filenames)
        {
            InitializeComponent();

            var validFilenames = from filename in filenames
                                 where Extension.IsMedia(filename)
                                 select filename;

            this.filenames = validFilenames.ToList();

            navigatingPeopleGroupBox.PictureBoxMain = pictureBoxMain;
            navigatingPeopleGroupBox.InitializePictureCrop();

            axWindowsMediaPlayer.Visible = false;
            pictureBoxMain.Visible = false;

            ClearForm();
        }

        private void ClearForm()
        {
            comboBoxGeneralWeather.DataSource = Enum.GetValues(typeof(WeatherDTO));
            comboBoxGeneralWeather.SelectedItem = WeatherDTO.None;

            navigatingPeopleGroupBox.ClearGroupBox();
            navigatingLocationsGroupBox.ClearGroupBox();

            Utils.ClearAllTextBoxes(this);

            ShowCurrentMediaData();
        }

        public void ShowCurrentMediaData()
        {
            string currentMediaFullPath = filenames.First();

            try
            {
                if (!File.Exists(currentMediaFullPath))
                    throw new FileNotFoundException();

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
            }
            catch (FileNotFoundException)
            {
                 MessageBox.Show(
                      "Media file doesn't exist anymore (" + Path.GetFileName(currentMediaFullPath) + "). Skipping to the next one.",
                      "Inexistent file",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation
                  );

                NextMedia();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Invalid media file supplied (" + Path.GetFileName(currentMediaFullPath) + "). Skipping to the next one.", 
                    "Invalid file", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation
                );

                NextMedia();
                return;
            }

            dateTimePickerDateCreated.Value = File.GetCreationTime(currentMediaFullPath);
            textBoxGeneralName.Text = Path.GetFileName(currentMediaFullPath);
            comboBoxGeneralWeather.SelectedItem = WeatherDTO.None;
        }

        public void SaveCurrentMediaData()
        {
            string currentImageFullPath = filenames.First();

            try
            {
                MultimediaDTO multimedia = new MultimediaDTO
                {
                    Path = currentImageFullPath,
                    Description = textBoxGeneralDescription.Text,
                    Event = textBoxGeneralEvent.Text,
                    Weather = (WeatherDTO) comboBoxGeneralWeather.SelectedItem,
                    AdditionalLabels = textBoxAdditionalLabels.Text,
                    DateCreated = dateTimePickerDateCreated.Value,
                    DateModified = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Deleted = false,
                    Locations = navigatingLocationsGroupBox.GetLocations().ToArray(),
                    People = navigatingPeopleGroupBox.GetPeople().ToArray()
                };

                MyPhotosServiceClient client = new MyPhotosServiceClient();
                client.AddMultimedia(multimedia);
            }
            catch (Exception e)
            {
                File.WriteAllText("Log.txt", e.ToString());
                MessageBox.Show("Couldn't save this media.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void NextMedia()
        {
            if (filenames.Count <= 1)
            {
                Close();
                return;
            }

            filenames.RemoveAt(0);
            ClearForm();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveCurrentMediaData();
            NextMedia();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            NextMedia();
        }
    }
}
