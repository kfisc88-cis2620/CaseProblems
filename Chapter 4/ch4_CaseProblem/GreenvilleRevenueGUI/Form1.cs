using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class GreenvilleRevenueGUI : Form
    {
        public GreenvilleRevenueGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            const double FEE = 25;

            double lastYear = Convert.ToDouble(txtLastYear.Text);
            double thisYear = Convert.ToDouble(txtThisYear.Text);
            
            previousRevenueLabel.Text = String.Format("The previous year's revenue was {0}", (lastYear * FEE).ToString("C"));
            currentRevenueLabel.Text = String.Format("The current year's revenue is {0}", (thisYear * FEE).ToString("C"));
            comparisonLabel.Text = String.Format("The difference between this year and last year's revenue was {0}", ((thisYear - lastYear) * FEE).ToString("C"));
            double lastYear = Convert.ToDouble(txtLastYear.Text);
            double thisYear = Convert.ToDouble(txtThisYear.Text);

            double difference = thisYear - lastYear;

            if (thisYear > lastYear * 2)
            {

            } else if (thisYear > lastYear && thisYear < lastYear * 2)
            {

            } else if (thisYear < lastYear)
            {

            }


            
            previousRevenueLabel.Text = $"The previous year's revenue was {lastYear.ToString("C2")}";
            currentRevenueLabel.Text = $"The current year's revenue is {thisYear.ToString("C2")}";

            comparisonLabel.Text = $"The difference between this year and last year's revenue was {difference.ToString("C2")}";
        }
    }
}
