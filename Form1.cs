using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPR___random___22SD___JaydenKlomp
{
    public partial class Form1 : Form
    {
        Random GenerateRandomValue = new Random();
        int maxValue = 0;
        int minValue = 0;
        int randomValue = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Randomizer";
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {

            maxValue = Convert.ToInt32(txbMaxValue.Text);

            minValue = Convert.ToInt32(txbMinValue.Text);

            randomValue = GenerateRandomValue.Next(minValue, maxValue);

            lblRandomValue.Text = randomValue.ToString();

            MessageBox.Show("The random value is: " + randomValue.ToString());
        }
    }
}
