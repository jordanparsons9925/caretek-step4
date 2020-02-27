using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Step4Prototype
{
    public partial class frmSchedulePCAs : Form
    {
        List<PCA> allPCA = new List<PCA>();
        ClientProxy currentClient;
        bool dragging = false;
        Label labelObject;
        Label newPCA;
        int xPos;
        int yPos;
        int xFullPos;
        int yFullPos;
        Point fullPos;

        public frmSchedulePCAs()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                labelObject = new Label();
                labelObject.AutoSize = true;
                labelObject.Text = ((Control)sender).Text;
                labelObject.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(labelObject);
                labelObject.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
                labelObject.BringToFront();
                dragging = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dragging)
            {
                xPos = Cursor.Position.X - this.Location.X - (8 + (labelObject.Width / 2));
                xFullPos = Cursor.Position.X - this.Location.X;
                yPos = Cursor.Position.Y - this.Location.Y - 40;
                yFullPos = Cursor.Position.Y - this.Location.Y;
                fullPos = new Point(xPos, yPos);
                labelObject.Location = fullPos;
            }
            lblDebug.Text = "Mouse X: " + xFullPos.ToString() + " Mouse Y: " + yFullPos.ToString() 
                + " Panel1 X: " + (panel1.Location.Y + flpSchedule.Location.Y).ToString() + ", " + (panel1.Location.Y + panel1.Width + flpSchedule.Location.Y).ToString();
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
                if (xFullPos >= panel1.Location.X + flpSchedule.Location.X  + 10
                    && xFullPos <= panel1.Location.X + panel1.Width + flpSchedule.Location.X + 10
                    && yFullPos >= panel1.Location.Y + flpSchedule.Location.Y + 37
                    && yFullPos <= panel1.Location.Y + panel1.Height + flpSchedule.Location.Y)
                {
                    Debug.Write("slot 1");
                    lblSlot1.Text = labelObject.Text;
                }
                this.Controls.Remove(labelObject);
                labelObject = null;
            }
        }

        private void frmSchedulePCAs_Load(object sender, EventArgs e)
        {
            allPCA = PCADB.GetPCAs();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            currentClient = ClientProxyDB.getClientProxies()[1];
            label2.Text = "Client: " + currentClient.Username;
            foreach (PCA currentPCA in allPCA)
            {
                if (Validation.validateRegion(currentPCA, currentClient))
                {
                    newPCA = new Label();
                    newPCA.AutoSize = true;
                    newPCA.Text = currentPCA.Username;
                    newPCA.BorderStyle = BorderStyle.FixedSingle;
                    flowLayoutPanel1.Controls.Add(newPCA);
                    newPCA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
                    newPCA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
                }
            }
            lblSlot1.Text = "PCA Needed";
            lblSlot2.Text = "PCA Needed";
            lblSlot3.Text = "PCA Needed";
            lblSlot4.Text = "PCA Needed";
            lblSlot5.Text = "PCA Needed";
            lblSlot6.Text = "PCA Needed";
            lblSlot7.Text = "PCA Needed";
            lblSlot8.Text = "PCA Needed";
            lblSlot9.Text = "PCA Needed";
            lblSlot10.Text = "PCA Needed";
            lblSlot11.Text = "PCA Needed";
            lblSlot12.Text = "PCA Needed";
            lblSlot13.Text = "PCA Needed";
            lblSlot14.Text = "PCA Needed";
            lblSlot15.Text = "";
            lblSlot16.Text = "";
            lblSlot17.Text = "";
            lblSlot18.Text = "";
            lblSlot19.Text = "";
            lblSlot20.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            currentClient = ClientProxyDB.getClientProxies()[0];
            label2.Text = "Client: " + currentClient.Username;
            foreach (PCA currentPCA in allPCA)
            {
                if (Validation.validateRegion(currentPCA, currentClient))
                {
                    newPCA = new Label();
                    newPCA.AutoSize = true;
                    newPCA.Text = currentPCA.Username;
                    newPCA.BorderStyle = BorderStyle.FixedSingle;
                    flowLayoutPanel1.Controls.Add(newPCA);
                    newPCA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
                    newPCA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
                }
            }
            lblSlot1.Text = "PCA Needed";
            lblSlot2.Text = "PCA Needed";
            lblSlot3.Text = "PCA Needed";
            lblSlot4.Text = "PCA Needed";
            lblSlot5.Text = "PCA Needed";
            lblSlot6.Text = "PCA Needed";
            lblSlot7.Text = "PCA Needed";
            lblSlot8.Text = "PCA Needed";
            lblSlot9.Text = "PCA Needed";
            lblSlot10.Text = "PCA Needed";
            lblSlot11.Text = "PCA Needed";
            lblSlot12.Text = "PCA Needed";
            lblSlot13.Text = "PCA Needed";
            lblSlot14.Text = "PCA Needed";
            lblSlot15.Text = "PCA Needed";
            lblSlot16.Text = "PCA Needed";
            lblSlot17.Text = "PCA Needed";
            lblSlot18.Text = "PCA Needed";
            lblSlot19.Text = "";
            lblSlot20.Text = "";
        }
    }
}
