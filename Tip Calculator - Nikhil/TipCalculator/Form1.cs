using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBill_TextChanged(object sender, EventArgs e)    //called when txtBill contents are changed 
        {
            Calculate();
        }


        private void txtTip_TextChanged(object sender, EventArgs e)       //called when txtTip contents are changed
        {
           
            Calculate();
        }

        private void txtPersons_TextChanged_1(object sender, EventArgs e)    //called when txtPersons contents are changed
        {
            Calculate();
        }

        void Calculate()      // function to validate the input boxes and display the output
        {
            if (String.IsNullOrEmpty(txtBill.Text) && String.IsNullOrEmpty(txtTip.Text) && String.IsNullOrEmpty(txtPersons.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtBill.Text) && String.IsNullOrEmpty(txtTip.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtTip.Text) && String.IsNullOrEmpty(txtPersons.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtBill.Text) && String.IsNullOrEmpty(txtPersons.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtBill.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtTip.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (String.IsNullOrEmpty(txtPersons.Text))
            {
                txtResult1.Text = txtResult2.Text = null;
            }

            else if (Convert.ToDouble(txtPersons.Text) < 1)
            {
                txtResult1.Text = txtResult2.Text = null;
            }
            else
            {
        
                txtResult1.Text = "$" + Math.Round(((Convert.ToDouble(txtBill.Text) * (Convert.ToDouble(txtTip.Text) / 100)) / Convert.ToDouble(txtPersons.Text)),2).ToString("F");
                txtResult2.Text = "$" + Math.Round(((Convert.ToDouble(txtBill.Text) + Convert.ToDouble(txtBill.Text) * (Convert.ToDouble(txtTip.Text)/100)) / Convert.ToDouble(txtPersons.Text)),2).ToString("F");
            }

        }

        private void minusTipButton_Click(object sender, EventArgs e)   //Method to define the functioning of (-) button on Tip 
        {
            if (String.IsNullOrEmpty(txtTip.Text))
            {
                txtTip.Text = "0";
            }
            else if (Convert.ToDouble(txtTip.Text) >= 1)
            {
                txtTip.Text = (Convert.ToDouble(txtTip.Text) - 1).ToString();
            }
        }

        private void addTipButton_Click(object sender, EventArgs e)     //Method to define the functioning of (+) button on Tip 
        {
            if (String.IsNullOrEmpty(txtTip.Text))
            {
                txtTip.Text = "1";
            }
            else
            {
                txtTip.Text = (Convert.ToDouble(txtTip.Text) + 1).ToString();
            }
           
        }

        private void minusPeopleButton_Click(object sender, EventArgs e)     //Method to define the functioning of (-) button on Number of People
        {
            if (String.IsNullOrEmpty(txtPersons.Text))
            {
                txtPersons.Text = "0";
            }
            else if  (Convert.ToDouble(txtPersons.Text) >= 1)
            {
                txtPersons.Text = (Convert.ToDouble(txtPersons.Text) - 1).ToString();
            }
        }

        private void addPeopleButton_Click(object sender, EventArgs e)     ////Method to define the functioning of (+) button on Number of People
        {
            if (String.IsNullOrEmpty(txtPersons.Text))
            {
                txtPersons.Text = "1";
            }
            else
            {
                txtPersons.Text = (Convert.ToDouble(txtPersons.Text) + 1).ToString();
            }

        } 


        private void txtPersons_KeyPress(object sender, KeyPressEventArgs e) // Method for Validating Proper Input in No of Persons TextBox
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter Numbers only");
            }
        }

        private void txtBill_KeyPress(object sender, KeyPressEventArgs e)  // Method For Validating Proper Input in Bill TextBox
        {
            if (txtBill.Text.Length == 0 || txtBill.Text.EndsWith(".") || txtBill.Text.Contains("."))
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                    MessageBox.Show("Incorrect Format!!");
                }
            }


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter Numbers only");
            }
        }

        private void txtTip_KeyPress(object sender, KeyPressEventArgs e) // Method for validating proper Input in Tip TextBox
        {
            if (txtTip.Text.Length == 0 || txtTip.Text.EndsWith(".") || txtTip.Text.Contains("."))
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                    MessageBox.Show("Incorrect Format!!");
                }
            }


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter Numbers Only");
            }
        }
        
    }
}
