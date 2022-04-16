namespace Weather
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Stadnaam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labPressure = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stad:";
            // 
            // Stadnaam
            // 
            this.Stadnaam.Location = new System.Drawing.Point(95, 60);
            this.Stadnaam.Name = "Stadnaam";
            this.Stadnaam.Size = new System.Drawing.Size(181, 22);
            this.Stadnaam.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voeg toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.Location = new System.Drawing.Point(431, 333);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(30, 16);
            this.labPressure.TabIndex = 23;
            this.labPressure.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Pressure:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.Location = new System.Drawing.Point(431, 287);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(30, 16);
            this.labWindSpeed.TabIndex = 21;
            this.labWindSpeed.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Wind Speed:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.Location = new System.Drawing.Point(431, 257);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(30, 16);
            this.labSunset.TabIndex = 19;
            this.labSunset.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sunset:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.Location = new System.Drawing.Point(431, 185);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(30, 16);
            this.labSunrise.TabIndex = 17;
            this.labSunrise.Text = "N/A";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Location = new System.Drawing.Point(340, 185);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(55, 16);
            this.labelSunrise.TabIndex = 16;
            this.labelSunrise.Text = "Sunrise:";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(340, 143);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(52, 16);
            this.labelDetails.TabIndex = 15;
            this.labelDetails.Text = "Details:";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(340, 102);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(66, 16);
            this.labelCondition.TabIndex = 14;
            this.labelCondition.Text = "Condition:";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.Location = new System.Drawing.Point(431, 217);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(30, 16);
            this.labTemp.TabIndex = 25;
            this.labTemp.Text = "N/A";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(340, 217);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(46, 16);
            this.labelTemp.TabIndex = 24;
            this.labelTemp.Text = "Temp:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.labelTemp);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Stadnaam);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Stadnaam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Label labelTemp;
    }
}

