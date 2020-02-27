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
        int shiftLength = 4;
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
                yPos = Cursor.Position.Y - this.Location.Y - 40;
                fullPos = new Point(xPos, yPos);
                labelObject.Location = fullPos;
            }
            xFullPos = Cursor.Position.X - this.Location.X - 9;
            yFullPos = Cursor.Position.Y - this.Location.Y - 32;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
                for (int i = 0; i < flpSchedule.Controls.Count; i++)
                {
                    Panel currentPanel = (Panel) flpSchedule.Controls[i];
                    if (xFullPos >= currentPanel.Location.X + flpSchedule.Location.X
                    && xFullPos <= currentPanel.Location.X + currentPanel.Width + flpSchedule.Location.X
                    && yFullPos >= currentPanel.Location.Y + flpSchedule.Location.Y
                    && yFullPos <= currentPanel.Location.Y + currentPanel.Height + flpSchedule.Location.Y)
                    {
                        Debug.Write(shiftLength);
                        switch (shiftLength)
                        {
                            case 4:
                                if (currentPanel.Controls[0].Text != "")
                                    currentPanel.Controls[0].Text = labelObject.Text;
                                break;
                            case 8:
                                if (currentPanel.Controls[0].Text != "" 
                                    && flpSchedule.Controls[i + 1].Controls[0].Text != "")
                                {
                                    currentPanel.Controls[0].Text = labelObject.Text;
                                    flpSchedule.Controls[i + 1].Controls[0].Text = labelObject.Text;
                                }
                                break;
                            case 12:
                                if (currentPanel.Controls[0].Text != ""
                                    && flpSchedule.Controls[i + 1].Controls[0].Text != ""
                                    && flpSchedule.Controls[i + 2].Controls[0].Text != "")
                                {
                                    currentPanel.Controls[0].Text = labelObject.Text;
                                    flpSchedule.Controls[i + 1].Controls[0].Text = labelObject.Text;
                                    flpSchedule.Controls[i + 2].Controls[0].Text = labelObject.Text;
                                }
                                break;
                        }
                        
                    }
                }
                
                this.Controls.Remove(labelObject);
                labelObject = null;
            }
        }

        private void frmSchedulePCAs_Load(object sender, EventArgs e)
        {
            //allPCA = PCADB.GetPCAs();
            updShiftLength.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            /*currentClient = ClientProxyDB.getClientProxies()[1];
            label2.Text = "Client: " + currentClient.Username;
            foreach (PCA currentPCA in allPCA)
            {
                if (Validation.validateRegion(currentPCA, currentClient))
                {
                    newPCA = new Label();
                    newPCA.AutoSize = true;
                    newPCA.Text = currentPCA.Username;
                    flowLayoutPanel1.Controls.Add(newPCA);
                    newPCA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
                    newPCA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
                }
            }*/
            int slotNumber = 1;
            string dayOfWeek = "Thursday";
            int startHour = 12;
            int endHour = 4;
            string startHalf = "pm";
            string endHalf = "am";
            foreach (Panel currentPanel in flpSchedule.Controls)
            {
                if (slotNumber++ <= 18)
                {
                    if (startHour == 12)
                    {
                        if (startHalf == "am")
                        {
                            startHalf = "pm";
                        }
                        else
                        {
                            startHalf = "am";
                            if (dayOfWeek == "Thursday")
                                dayOfWeek = "Friday";
                            else if (dayOfWeek == "Friday")
                                dayOfWeek = "Saturday";
                            else if (dayOfWeek == "Saturday")
                                dayOfWeek = "Sunday";
                        }
                    }
                    if (startHour > 12)
                        startHour -= 12;
                    if (endHour == 12)
                    {
                        if (endHalf == "am")
                        {
                            endHalf = "pm";
                        }
                        else
                        {
                            endHalf = "am";
                        }
                    }
                    if (endHour > 12)
                        endHour -= 12;
                    currentPanel.Controls[1].Text = dayOfWeek + "\n" + startHour.ToString() + ":00" + startHalf + " - " + (endHour).ToString() + ":00" + endHalf;
                    currentPanel.Controls[0].Text = "PCA Needed";
                    startHour += 4;
                    endHour += 4;
                }
                else
                {
                    currentPanel.Controls[1].Text = "";
                    currentPanel.Controls[0].Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            /*currentClient = ClientProxyDB.getClientProxies()[0];
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
            }*/
            int slotNumber = 1;
            foreach (Panel currentPanel in flpSchedule.Controls)
            {
                /*if (slotNumber++ <= 14)
                {
                    if (startHour == 12)
                    {
                        if (startHalf == "am")
                        {
                            startHalf = "pm";
                        }
                        else
                        {
                            startHalf = "am";
                            if (dayOfWeek == "Thursday")
                                dayOfWeek = "Friday";
                            else if (dayOfWeek == "Friday")
                                dayOfWeek = "Saturday";
                            else if (dayOfWeek == "Saturday")
                                dayOfWeek = "Sunday";
                        }
                    }
                    if (startHour > 12)
                        startHour -= 12;
                    if (endHour == 12)
                    {
                        if (endHalf == "am")
                        {
                            endHalf = "pm";
                        }
                        else
                        {
                            endHalf = "am";
                        }
                    }
                    if (endHour > 12)
                        endHour -= 12;
                    currentPanel.Controls[1].Text = dayOfWeek + "\n" + startHour.ToString() + ":00" + startHalf + " - " + (endHour).ToString() + ":00" + endHalf;
                    currentPanel.Controls[0].Text = "PCA Needed";
                    startHour += 4;
                    endHour += 4;
                }
                else
                {
                    currentPanel.Controls[1].Text = "";
                    currentPanel.Controls[0].Text = "";
                }*/
            }
        }

        private void updShiftLength_SelectedItemChanged(object sender, EventArgs e)
        {
            shiftLength = Int32.Parse(updShiftLength.Text);
        }
    }
}
