using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        //create list to hold labels
        List<Label> labels = new List<Label>();

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //add all labels to list
            labels.Add(todayLabel);
            labels.Add(forecastLabel);
            labels.Add(lineLabel);
            labels.Add(cityOutput);
            labels.Add(tempLabel);
            labels.Add(currentOutput);
            labels.Add(label4);
            labels.Add(maxOutput);
            labels.Add(label10);
            labels.Add(maxLabel);
            labels.Add(minOutput);
            labels.Add(label2);
            labels.Add(minLabel);
            labels.Add(windSpeedLabel);
            labels.Add(speedOutput);
            labels.Add(windDirectionLabel);
            labels.Add(directionOutput);
            labels.Add(precipitationLabel);
            labels.Add(precipitationOutput);

            //display weather values to screen
            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Form1.days[0].currentTemp;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;
            speedOutput.Text = Form1.days[0].windSpeed + " mps";
            directionOutput.Text = Form1.days[0].windDirection;
            precipitationOutput.Text = Form1.days[0].precipitation;

            //change background to reflect weather for the day
            int n = Convert.ToInt16(Form1.days[0].condition);

            if (200 <= n && n <= 531)
            {
                this.BackgroundImage = Properties.Resources.rainy;
            }
            else if (600 <= n && n <= 622)
            {
                foreach (Label l in labels)
                {
                    l.ForeColor = Color.Black;
                }
                this.BackgroundImage = Properties.Resources.snowy;
            }
            else if (n == 800)
            {
                foreach (Label l in labels)
                {
                    l.ForeColor = Color.Black;
                }
                this.BackgroundImage = Properties.Resources.sunny;
            }
            else if (n == 801)
            {
                foreach (Label l in labels)
                {
                    l.ForeColor = Color.Black;
                }
                this.BackgroundImage = Properties.Resources.partlycloudy;
            }
            else if (802 <= n && n <= 804)
            {
                foreach (Label l in labels)
                {
                    l.ForeColor = Color.Black;
                }
                this.BackgroundImage = Properties.Resources.cloudy;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
