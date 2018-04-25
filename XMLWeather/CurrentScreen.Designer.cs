namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.windDirectionLabel = new System.Windows.Forms.Label();
            this.precipitationLabel = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.speedOutput = new System.Windows.Forms.Label();
            this.directionOutput = new System.Windows.Forms.Label();
            this.precipitationOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Navy;
            this.cityOutput.Location = new System.Drawing.Point(25, 87);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(241, 23);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.Color.Navy;
            this.maxLabel.Location = new System.Drawing.Point(27, 277);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(26, 13);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.Color.Navy;
            this.minLabel.Location = new System.Drawing.Point(161, 277);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(23, 13);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // currentOutput
            // 
            this.currentOutput.AutoSize = true;
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.Navy;
            this.currentOutput.Location = new System.Drawing.Point(99, 144);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(103, 39);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "99.99";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.Navy;
            this.tempLabel.Location = new System.Drawing.Point(54, 120);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(191, 24);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(39, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.Navy;
            this.forecastLabel.Location = new System.Drawing.Point(177, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(21, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateOutput
            // 
            this.dateOutput.AutoSize = true;
            this.dateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.Navy;
            this.dateOutput.Location = new System.Drawing.Point(27, 63);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(39, 18);
            this.dateOutput.TabIndex = 65;
            this.dateOutput.Text = "Date";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.ForeColor = System.Drawing.Color.Navy;
            this.windSpeedLabel.Location = new System.Drawing.Point(17, 344);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(66, 13);
            this.windSpeedLabel.TabIndex = 66;
            this.windSpeedLabel.Text = "Wind Speed";
            // 
            // windDirectionLabel
            // 
            this.windDirectionLabel.AutoSize = true;
            this.windDirectionLabel.ForeColor = System.Drawing.Color.Navy;
            this.windDirectionLabel.Location = new System.Drawing.Point(17, 381);
            this.windDirectionLabel.Name = "windDirectionLabel";
            this.windDirectionLabel.Size = new System.Drawing.Size(77, 13);
            this.windDirectionLabel.TabIndex = 67;
            this.windDirectionLabel.Text = "Wind Direction";
            // 
            // precipitationLabel
            // 
            this.precipitationLabel.AutoSize = true;
            this.precipitationLabel.ForeColor = System.Drawing.Color.Navy;
            this.precipitationLabel.Location = new System.Drawing.Point(17, 418);
            this.precipitationLabel.Name = "precipitationLabel";
            this.precipitationLabel.Size = new System.Drawing.Size(65, 13);
            this.precipitationLabel.TabIndex = 68;
            this.precipitationLabel.Text = "Precipitation";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.Navy;
            this.maxOutput.Location = new System.Drawing.Point(19, 228);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(103, 39);
            this.maxOutput.TabIndex = 69;
            this.maxOutput.Text = "99.99";
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.Navy;
            this.minOutput.Location = new System.Drawing.Point(157, 228);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(103, 39);
            this.minOutput.TabIndex = 70;
            this.minOutput.Text = "99.99";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(113, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "ºC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(251, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "ºC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(193, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "ºC";
            // 
            // speedOutput
            // 
            this.speedOutput.AutoSize = true;
            this.speedOutput.ForeColor = System.Drawing.Color.Navy;
            this.speedOutput.Location = new System.Drawing.Point(158, 344);
            this.speedOutput.Name = "speedOutput";
            this.speedOutput.Size = new System.Drawing.Size(35, 13);
            this.speedOutput.TabIndex = 98;
            this.speedOutput.Text = "label1";
            // 
            // directionOutput
            // 
            this.directionOutput.AutoSize = true;
            this.directionOutput.ForeColor = System.Drawing.Color.Navy;
            this.directionOutput.Location = new System.Drawing.Point(158, 381);
            this.directionOutput.Name = "directionOutput";
            this.directionOutput.Size = new System.Drawing.Size(35, 13);
            this.directionOutput.TabIndex = 99;
            this.directionOutput.Text = "label1";
            // 
            // precipitationOutput
            // 
            this.precipitationOutput.AutoSize = true;
            this.precipitationOutput.ForeColor = System.Drawing.Color.Navy;
            this.precipitationOutput.Location = new System.Drawing.Point(158, 418);
            this.precipitationOutput.Name = "precipitationOutput";
            this.precipitationOutput.Size = new System.Drawing.Size(35, 13);
            this.precipitationOutput.TabIndex = 100;
            this.precipitationOutput.Text = "label1";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.precipitationOutput);
            this.Controls.Add(this.directionOutput);
            this.Controls.Add(this.speedOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.precipitationLabel);
            this.Controls.Add(this.windDirectionLabel);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(300, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Label windDirectionLabel;
        private System.Windows.Forms.Label precipitationLabel;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label speedOutput;
        private System.Windows.Forms.Label directionOutput;
        private System.Windows.Forms.Label precipitationOutput;
    }
}
