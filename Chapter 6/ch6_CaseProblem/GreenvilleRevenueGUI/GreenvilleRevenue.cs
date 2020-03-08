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

            if ((lastYear >= 0 && lastYear <= 30) && (thisYear >= 0 && lastYear <= 30))
            {
                // Clear error label text
                errorLabel.Text = "";

                // Compare thisYear no. of contestants to lastYear
                if (thisYear > lastYear * 2)
                    competitionLabel.Text = "The competition is more than twice as big as last year!";
                else if (thisYear > lastYear && thisYear <= lastYear * 2)
                    competitionLabel.Text = "The competition is bigger than ever!";
                else
                    competitionLabel.Text = "A tighter race this year! Come out and cast your vote!";

                previousRevenueLabel.Text = String.Format("The previous year's revenue was {0}", (lastYear * FEE).ToString("C"));
                currentRevenueLabel.Text = String.Format("The current year's revenue is {0}", (thisYear * FEE).ToString("C"));
                comparisonLabel.Text = String.Format("The difference between this year and last year's revenue was {0}", ((thisYear - lastYear) * FEE).ToString("C"));
            } else
            {
                // Clear all other label text and display error
                previousRevenueLabel.Text = "";
                currentRevenueLabel.Text = "";
                comparisonLabel.Text = "";
                competitionLabel.Text = "";
                errorLabel.Text = "Please enter a valid number from 0 to 30.";
            }
        }
    }
}
