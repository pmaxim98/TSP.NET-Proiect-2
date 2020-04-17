using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using MyPhotos.DTO;

namespace MyPhotosGUI
{
    public partial class NavigatingLocationsGroupBox : UserControl
    {
        private int index;

        private List<LocationDTO> locations = new List<LocationDTO>();

        public NavigatingLocationsGroupBox()
        {
            InitializeComponent();

            textBoxLocationsLatitude.Validating += TextBoxLocationsLatitude_Validating;
            textBoxLocationsLongitude.Validating += TextBoxLocationsLongitude_Validating;

            groupBox.Text = "Locations (0/0)";

            ClearGroupBox();
        }

        public void ClearGroupBox()
        {
            Utils.ClearAllTextBoxes(groupBox);
            Utils.SetGroupBoxCounter(groupBox, 0, 0);
            Utils.EnableControl(groupBox, false);

            locations = new List<LocationDTO>();
            index = -1;
            buttonNew.Enabled = true;
        }

        public void Set(List<LocationDTO> locations)
        {
            ClearGroupBox();

            this.locations = locations;

            if (this.locations.Count == 0)
                return;

            index = Utils.Next(index, this.locations, groupBox);
            LocationToGroupBox();
            Utils.EnableControl(groupBox, true);
        }

        public LocationDTO GetCurrentItem()
        {
            if (locations.Count > 0 && index >= 0)
                return locations[index];

            return new LocationDTO();
        }

        public List<LocationDTO> GetLocations()
        {
            return locations;
        }

        private void LocationToGroupBox()
        {
            LocationDTO location = GetCurrentItem();

            textBoxLocationsName.Text = location.Name;
            textBoxLocationsScenery.Text = location.Scenery;
            textBoxLocationsZipcode.Text = location.ZipCode;
            textBoxLocationsLongitude.Text = location.Longitude.HasValue ? location.Longitude.ToString() : string.Empty;
            textBoxLocationsLatitude.Text = location.Latitude.HasValue ? location.Latitude.ToString() : string.Empty;
        }

        private void GroupBoxToLocation()
        {
            LocationDTO location = GetCurrentItem();

            location.Name = textBoxLocationsName.Text;
            location.Scenery = textBoxLocationsScenery.Text;
            location.ZipCode = textBoxLocationsZipcode.Text;

            if (!string.IsNullOrWhiteSpace(textBoxLocationsLongitude.Text))
                location.Longitude = Convert.ToDecimal(textBoxLocationsLongitude.Text);
            else
                location.Longitude = null;

            if (!string.IsNullOrWhiteSpace(textBoxLocationsLatitude.Text))
                location.Latitude = Convert.ToDecimal(textBoxLocationsLatitude.Text);
            else
                location.Latitude = null;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            index = Utils.Prev(index, locations, groupBox);
            LocationToGroupBox();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            index = Utils.Next(index, locations, groupBox);
            LocationToGroupBox();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Utils.RemoveItemFromGroupBox(locations, ref index, groupBox, buttonNew);
            LocationToGroupBox();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            GroupBoxToLocation();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Utils.AddEmptyItemToGroupBox(locations, ref index, groupBox);
            LocationToGroupBox();
        }

        private void TextBoxLocationsLatitude_Validating(object sender, CancelEventArgs e)
        {
            if (Utils.IsValidDecimal(textBoxLocationsLatitude.Text))
            {
                errorProvider.SetError(textBoxLocationsLatitude, string.Empty);
                return;
            }

            e.Cancel = true;
            textBoxLocationsLatitude.Select(0, textBoxLocationsLatitude.Text.Length);
            errorProvider.SetError(textBoxLocationsLatitude, "Only real numbers allowed!");
        }

        private void TextBoxLocationsLongitude_Validating(object sender, CancelEventArgs e)
        {
            if (Utils.IsValidDecimal(textBoxLocationsLongitude.Text))
            {
                errorProvider.SetError(textBoxLocationsLongitude, string.Empty);
                return;
            }

            e.Cancel = true;
            textBoxLocationsLongitude.Select(0, textBoxLocationsLongitude.Text.Length);
            errorProvider.SetError(textBoxLocationsLongitude, "Only real numbers allowed!");
        }
    }
}
