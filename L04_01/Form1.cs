using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L04_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int Sum(int number1, int number2)
        {
            int resultingSum;
            resultingSum = number1 + number2;

            return resultingSum;
        }

        private void btnGetSum_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(txtFirst.Text);
            int second = Convert.ToInt32(txtSecond.Text);
            int ans = Sum(first, second);
            
            lblSum.Text = $"The sum is: {ans}";
        }

        private void txtFirst_Enter(object sender, EventArgs e)
        {
            txtFirst.SelectAll();
        }

        private void txtSecond_Enter(object sender, EventArgs e)
        {
            txtSecond.SelectAll();
        }
    }
}
