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

            double lastYear = Convert.ToDouble(txtLastYear.Text) * FEE;
            double thisYear = Convert.ToDouble(txtThisYear.Text) * FEE;

            double difference = thisYear - lastYear;
            
            previousRevenueLabel.Text = $"The previous year's revenue was {lastYear.ToString("C2")}";
            currentRevenueLabel.Text = $"The current year's revenue is {thisYear.ToString("C2")}";
        }
    }
}
