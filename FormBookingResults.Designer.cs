namespace Step4Prototype
{
    partial class FormBookingResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Step IV Prototype";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "CareTek Solutions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your appointment for x is confirmed";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(106, 102);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(100, 45);
            this.BtnOk.TabIndex = 8;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // FormBookingResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 368);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "FormBookingResults";
            this.Text = "FormBookingResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOk;
    }
}