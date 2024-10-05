using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRIME_WHEN_INPUT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (txtNum.Text.Length == 0)
            {
                txtFactors.Text = "";
                rtxtFactors.Text = "";
                return;
            }
            if (txtNum.Text.Length > 18)
            {
                MessageBox.Show("Number is too large! AAAAA");
                return;
            }
            txtFactors.Text = "";
            rtxtFactors.Text = "";
            long n = long.Parse(txtNum.Text);
            if (n == 1)
            {
                txtFactors.Text = "Sadly, 1 can not be factorized.";
                rtxtFactors.Text = "Sadly, 1 can not be factorized.";
                return;
            }
            for (long i = 2; i <= Math.Sqrt(n); i++)
            if (n%i==0)
            {
                int cnt = 0;
                while (n % i == 0)
                {
                    cnt++;
                        if (txtFactors.Text.Length > 0)
                            txtFactors.Text += " . ";
                    txtFactors.Text += i.ToString();
                    n /= i;
                }
                rtxtFactors.SelectionFont = new Font("Microsoft Sans Serif", 16);
                    // Set the baseline text.
                    if (rtxtFactors.Text.Length > 0)
                    { 
                        rtxtFactors.SelectionFont = new Font("Microsoft Sans Serif", 16);
                        // Set the baseline text.
                        rtxtFactors.SelectedText = " . ";
                        rtxtFactors.SelectionCharOffset = 0;
                    }
                    rtxtFactors.SelectedText = i.ToString();
                if (cnt != 1)
                {
                    // Set the CharOffset to display superscript text.
                    rtxtFactors.SelectionCharOffset = 10;
                    rtxtFactors.SelectionFont = new Font("Microsoft Sans Serif", 10);
                    // Set the superscripted text.  
                    rtxtFactors.SelectedText = cnt.ToString();
                    // Reset the CharOffset to display text at the baseline.
                    rtxtFactors.SelectionCharOffset = 0;
                }
            }
            if (n != 1)
            {
                if (txtFactors.Text.Length > 0)
                {
                    txtFactors.Text += " . ";
                    rtxtFactors.SelectionFont = new Font("Microsoft Sans Serif", 16);
                    // Set the baseline text.
                    rtxtFactors.SelectedText = " . ";
                    rtxtFactors.SelectionCharOffset = 0;
                }
                rtxtFactors.SelectionFont = new Font("Microsoft Sans Serif", 16);
                txtFactors.Text += n.ToString();
                rtxtFactors.SelectedText = n.ToString();
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                int position = txtNum.SelectionStart;
                if (position == 0) e.Handled = true;
            }
            else if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right) e.Handled = false;
            else e.Handled = true;
        }
    }
}
