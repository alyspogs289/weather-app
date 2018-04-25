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
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            dateOutput.Text = Form1.days[0].date;
            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Form1.days[0].currentTemp;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;
            speedOutput.Text = Form1.days[0].windSpeed;
            directionOutput.Text = Form1.days[0].windDirection;
            precipitationOutput.Text = Form1.days[0].precipitation;

            int n = Convert.ToInt16(Form1.days[0].condition);

            if (200 <= n && n <= 531)
            {
                this.BackgroundImage = Properties.Resources.rainy;
            }
            else if (600 <= n && n <= 622)
            {
                this.BackgroundImage = Properties.Resources.snowy;
            }
            else if (n == 800)
            {
                this.BackgroundImage = Properties.Resources.sunny;
            }
            else if (n == 801)
            {
                this.BackgroundImage = Properties.Resources.partlycloudy;
            }
            else if (802 <= n && n <= 804)
            {
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
