namespace Weather
{
    partial class Form2
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
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(50, 48);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(66, 16);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = "Condition:";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(50, 89);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(52, 16);
            this.labelDetails.TabIndex = 1;
            this.labelDetails.Text = "Details:";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Location = new System.Drawing.Point(50, 131);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(55, 16);
            this.labelSunrise.TabIndex = 2;
            this.labelSunrise.Text = "Sunrise:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.Location = new System.Drawing.Point(141, 131);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(30, 16);
            this.labSunrise.TabIndex = 4;
            this.labSunrise.Text = "N/A";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.Location = new System.Drawing.Point(141, 203);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(30, 16);
            this.labSunset.TabIndex = 9;
            this.labSunset.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sunset:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.Location = new System.Drawing.Point(141, 233);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(30, 16);
            this.labWindSpeed.TabIndex = 11;
            this.labWindSpeed.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wind Speed:";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.Location = new System.Drawing.Point(141, 279);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(30, 16);
            this.labPressure.TabIndex = 13;
            this.labPressure.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pressure:";
            // 
            // picicon
            // 
            this.picicon.BackColor = System.Drawing.Color.Transparent;
            this.picicon.Location = new System.Drawing.Point(429, 55);
            this.picicon.Name = "picicon";
            this.picicon.Size = new System.Drawing.Size(100, 50);
            this.picicon.TabIndex = 14;
            this.picicon.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picicon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.labelSunrise);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelCondition);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picicon;
    }
}