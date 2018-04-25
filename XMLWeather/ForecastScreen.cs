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
    public partial class ForecastScreen : UserControl
    {
        int d = 1;

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;
            checkConditions();

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;
            d = 2;
            checkConditions();

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;
            d = 3;
            checkConditions();

            date4.Text = Form1.days[4].date;
            min4.Text = Form1.days[4].tempLow;
            max4.Text = Form1.days[4].tempHigh;
            d = 4;
            checkConditions();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void checkConditions()
        {
            int n = Convert.ToInt16(Form1.days[d].condition);
            
            if (200 <= n && n <= 531)
            {
                if (d == 1)
                {
                    icon1.BackgroundImage = Properties.Resources.rainyicon;
                }
                else if (d == 2)
                {
                    icon2.BackgroundImage = Properties.Resources.rainyicon;
                }
                else if (d == 3)
                {
                    icon3.BackgroundImage = Properties.Resources.rainyicon;
                }
                else if (d == 4)
                {
                    icon4.BackgroundImage = Properties.Resources.rainyicon;
                }

            }
            else if (600 <= n && n <= 622)
            {
                if (d == 1)
                {
                    icon1.BackgroundImage = Properties.Resources.snowyicon;
                }
                else if (d == 2)
                {
                    icon2.BackgroundImage = Properties.Resources.snowyicon;
                }
                else if (d == 3)
                {
                    icon3.BackgroundImage = Properties.Resources.snowyicon;
                }
                else if (d == 4)
                {
                    icon4.BackgroundImage = Properties.Resources.snowyicon;
                }
            }
            else if (n == 800)
            {
                if (d == 1)
                {
                    icon1.BackgroundImage = Properties.Resources.sunnyicon;
                }
                else if (d == 2)
                {
                    icon2.BackgroundImage = Properties.Resources.sunnyicon;
                }
                else if (d == 3)
                {
                    icon3.BackgroundImage = Properties.Resources.sunnyicon;
                }
                else if (d == 4)
                {
                    icon4.BackgroundImage = Properties.Resources.sunnyicon;
                }
            }
            else if (n == 801)
            {
                if (d == 1)
                {
                    icon1.BackgroundImage = Properties.Resources.partlycloudyicon;
                }
                else if (d == 2)
                {
                    icon2.BackgroundImage = Properties.Resources.partlycloudyicon;
                }
                else if (d == 3)
                {
                    icon3.BackgroundImage = Properties.Resources.partlycloudyicon;
                }
                else if (d == 4)
                {
                    icon4.BackgroundImage = Properties.Resources.partlycloudyicon;
                }
            }
            else if (802 <= n && n <= 804)
            {
                if (d == 1)
                {
                    icon1.BackgroundImage = Properties.Resources.cloudyicon;
                }
                else if (d == 2)
                {
                    icon2.BackgroundImage = Properties.Resources.cloudyicon;
                }
                else if (d == 3)
                {
                    icon3.BackgroundImage = Properties.Resources.cloudyicon;
                }
                else if (d == 4)
                {
                    icon4.BackgroundImage = Properties.Resources.cloudyicon;
                }
            }
        }
    }
}
