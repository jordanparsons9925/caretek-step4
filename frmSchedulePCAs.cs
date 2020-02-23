using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Step4Prototype
{
    public partial class frmSchedulePCAs : Form
    {
        bool dragging = false;
        Label labelObject;
        int xPos;
        int yPos;
        Point fullPos;

        public frmSchedulePCAs()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            labelObject = new Label();
            labelObject.AutoSize = true;
            labelObject.Text = ((Control) sender).Text;
            labelObject.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(labelObject);
            labelObject.BringToFront();
            dragging = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dragging)
            {
                xPos = Cursor.Position.X - this.Location.X - (8 + (labelObject.Width / 2));
                yPos = Cursor.Position.Y - this.Location.Y - 40;
                fullPos = new Point(xPos, yPos);
                labelObject.Location = fullPos;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
