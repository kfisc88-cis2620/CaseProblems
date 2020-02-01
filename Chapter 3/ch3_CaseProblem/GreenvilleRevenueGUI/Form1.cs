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
            double lastYear = Convert.ToDouble(txtLastYear.Text);
            double thisYear = Convert.ToDouble(txtThisYear.Text);
            const double fee = 25;
        }
    }
}
