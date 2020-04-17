using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    static public class Utils
    {
        public static void ClearAllTextBoxes(Form form)
        {
            foreach (GroupBox groupBox in form.Controls.OfType<GroupBox>().ToList())
                foreach (TextBox textBox in groupBox.Controls.OfType<TextBox>().ToList())
                    textBox.Text = string.Empty;

            foreach (TextBox textBox in form.Controls.OfType<TextBox>().ToList())
                textBox.Text = string.Empty;
        }

        public static void ClearAllTextBoxes(GroupBox groupBox)
        {
            foreach (TextBox textBox in groupBox.Controls.OfType<TextBox>().ToList())
                textBox.Text = string.Empty;
        }

        public static void EnableAllControlsOfType<T>(Control control, bool enabled) where T : Control
        {
            foreach (T c in control.Controls.OfType<T>().ToList())
                c.Enabled = enabled;
        }

        public static void EnableControl(Control control, bool enabled)
        {
            EnableAllControlsOfType<Button>(control, enabled);
            EnableAllControlsOfType<TextBox>(control, enabled);
            EnableAllControlsOfType<PictureBox>(control, enabled);
        }

        public static void SetGroupBoxCounter(GroupBox groupBox, int current, int total)
        {
            groupBox.Text = groupBox.Text.Remove(groupBox.Text.IndexOf('('));
            groupBox.Text += "(" + current + "/" + total + ")";
        }

        public static void AddEmptyItemToGroupBox<T>(List<T> list, ref int index, GroupBox groupBox) where T : new()
        {
            T t = new T();

            list.Add(t);

            index = list.Count - 1;

            SetGroupBoxCounter(groupBox, index + 1, list.Count);

            if (index == 0)
            {
                EnableControl(groupBox, true);
            }
        }

        public static void RemoveItemFromGroupBox<T>(List<T> list, ref int index, GroupBox groupBox, Button newItemButton) where T : new()
        {
            list.RemoveAt(index);

            if (list.Count == 0)
            {
                index = -1;
                EnableControl(groupBox, false);
                SetGroupBoxCounter(groupBox, index + 1, list.Count);
                newItemButton.Enabled = true;
                return;
            }

            index = Prev(index, list, groupBox);
        }

        public static int Next<T>(int index, List<T> list, GroupBox groupBox)
        {
            int next = (index + 1) % list.Count;
            SetGroupBoxCounter(groupBox, next + 1, list.Count);
            return next;
        }

        public static int Prev<T>(int index, List<T> list, GroupBox groupBox)
        {
            int prev = list.Count - 1;

            if (index > 0)
                prev = (index - 1) % list.Count;

            SetGroupBoxCounter(groupBox, prev + 1, list.Count);
            return prev;
        }

        public static Rectangle PointsToRectangle(Point a, Point b, Size size)
        {
            return Rectangle.FromLTRB(
               Math.Max(0, Math.Min(a.X, b.X)),
               Math.Max(0, Math.Min(a.Y, b.Y)),
               Math.Min(size.Width, Math.Max(a.X, b.X)),
               Math.Min(size.Height, Math.Max(a.Y, b.Y))
           );
        }

        public static void CropFromPictureBox(PictureBox source, PictureBox destination, Rectangle croppingRectangle)
        {
            using (Bitmap bitmap = new Bitmap(source.Width, source.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                    g.DrawImage(source.Image, new Rectangle(0, 0, source.Width, source.Height));

                destination.Image?.Dispose();

                destination.Image = bitmap.Clone(croppingRectangle, source.Image.PixelFormat);
            }
        }

        public static bool IsValidDecimal(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return true;

            try { Convert.ToDecimal(str); }
            catch (Exception) { return false; }

            return true;
        }

        public static bool IsValidAge(string age)
        {
            if (string.IsNullOrWhiteSpace(age))
                return true;

            try { Convert.ToInt16(age); }
            catch (Exception) { return false; }

            return true;
        }

    }
}
