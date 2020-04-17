using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using MyPhotos.DTO;

namespace MyPhotosGUI
{
    public partial class NavigatingPeopleGroupBox : UserControl
    {
        private int index;

        private List<PersonDTO> people = new List<PersonDTO>();
        public PictureBox PictureBoxMain { get; set; }

        private PictureCrop pictureCrop;

        public NavigatingPeopleGroupBox()
        {
            InitializeComponent();

            textBoxPeopleAge.Validating += TextBoxPeopleAge_Validating;

            groupBox.Text = "People (0/0)";

            ClearGroupBox();
        }

        public void InitializePictureCrop()
        {
            pictureCrop = new PictureCrop(PictureBoxMain, pictureBoxPerson);

            PictureBoxMain.MouseDown += pictureCrop.MouseDown;
            PictureBoxMain.MouseUp += pictureCrop.MouseUp;
            PictureBoxMain.MouseMove += pictureCrop.MouseMove;
            PictureBoxMain.Paint += pictureCrop.Paint;
        }

        public void ClearGroupBox()
        {
            Utils.ClearAllTextBoxes(groupBox);
            Utils.SetGroupBoxCounter(groupBox, 0, 0);
            Utils.EnableControl(groupBox, false);

            people = new List<PersonDTO>();
            index = -1;
            buttonNew.Enabled = true;
            pictureBoxPerson.Image = null;
        }

        public void Set(List<PersonDTO> people)
        {
            ClearGroupBox();

            this.people = people;

            if (this.people.Count == 0)
                return;

            index = Utils.Next(index, this.people, groupBox);
            PersonToGroupBox();
            Utils.EnableControl(groupBox, true);
        }

        public List<PersonDTO> GetPeople()
        {
            return people;
        }

        public PersonDTO GetCurrentItem()
        {
            if (people.Count > 0 && index >= 0)
                return people[index];

            return new PersonDTO();
        }

        private void PersonToGroupBox()
        {
            PersonDTO person = GetCurrentItem();

            textBoxPeopleFirstName.Text = person.FirstName;
            textBoxPeopleLastName.Text = person.LastName;
            textBoxPeopleAge.Text = person.Age.HasValue ? person.Age.ToString() : string.Empty;

            if (person.Photo != null)
            {
                Rectangle croppingRectangle = new Rectangle(person.Photo.X, person.Photo.Y, person.Photo.Width, person.Photo.Height);
                Utils.CropFromPictureBox(PictureBoxMain, pictureBoxPerson, croppingRectangle);
            }
            else
            {
                pictureBoxPerson.Image = null;
            }
        }

        private void GroupBoxToPerson()
        {
            PersonDTO person = GetCurrentItem();

            person.FirstName = textBoxPeopleFirstName.Text;
            person.LastName = textBoxPeopleLastName.Text;

            if (!string.IsNullOrWhiteSpace(textBoxPeopleAge.Text))
                person.Age = Convert.ToInt16(textBoxPeopleAge.Text);
            else
                person.Age = null;

            if (pictureBoxPerson.Image != null)
            {
                person.Photo = new PhotoDTO()
                {
                    X = pictureCrop.CroppingRectangle.X,
                    Y = pictureCrop.CroppingRectangle.Y,
                    Width = pictureCrop.CroppingRectangle.Width,
                    Height = pictureCrop.CroppingRectangle.Height
                };
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            index = Utils.Prev(index, people, groupBox);
            PersonToGroupBox();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            index = Utils.Next(index, people, groupBox);
            PersonToGroupBox();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Utils.RemoveItemFromGroupBox(people, ref index, groupBox, buttonNew);
            PersonToGroupBox();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            GroupBoxToPerson();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Utils.AddEmptyItemToGroupBox(people, ref index, groupBox);
            PersonToGroupBox();
        }

        private void TextBoxPeopleAge_Validating(object sender, CancelEventArgs e)
        {
            if (Utils.IsValidAge(textBoxPeopleAge.Text))
            {
                errorProvider.SetError(textBoxPeopleAge, string.Empty);
                return;
            }

            e.Cancel = true;
            textBoxPeopleAge.Select(0, textBoxPeopleAge.Text.Length);
            errorProvider.SetError(textBoxPeopleAge, "Invalid age!");
        }

        private void pictureBoxPerson_Click(object sender, EventArgs e)
        {
            PictureBoxMain.Cursor = Cursors.Cross;
        }
    }
}
