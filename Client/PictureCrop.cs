using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public class PictureCrop
    {
        private Point startPointPhoto;
        private Point currentPointPhoto;
        private Point endPointPhoto;

        private bool firstPointClicked = false;

        private PictureBox source;
        private PictureBox destination;

        public Rectangle CroppingRectangle { get; set; }

        public PictureCrop(PictureBox source, PictureBox destination)
        {
            this.source = source;
            this.destination = destination;
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (source.Cursor != Cursors.Cross || !firstPointClicked)
                return;

            currentPointPhoto = e.Location;

            source.Refresh();
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            if (source.Cursor != Cursors.Cross)
                return;

            Graphics g = e.Graphics;

            Point[] points = new Point[4]
            {
                startPointPhoto,
                new Point(startPointPhoto.X, currentPointPhoto.Y),
                currentPointPhoto,
                new Point(currentPointPhoto.X, startPointPhoto.Y)
            };

            g.DrawPolygon(Pens.Red, points);
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            if (source.Cursor != Cursors.Cross)
                return;

            endPointPhoto = e.Location;

            firstPointClicked = false;

            source.Cursor = Cursors.Default;

            source.Refresh();

            CroppingRectangle = Utils.PointsToRectangle(startPointPhoto, endPointPhoto, source.Size);
            Utils.CropFromPictureBox(source, destination, CroppingRectangle);
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (source.Cursor != Cursors.Cross)
                return;

            firstPointClicked = true;

            startPointPhoto = e.Location;
        }
    }
}
