using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Project: Calculator 2.0
    Programmer: Julie Green
    Date: Apr 20, 2016
    Purpose: Performs simple calculations and math operations with two number inputs.
*/

namespace Julie_Green_Lab_4
{
    public partial class frmMain : Form
    {
        private const string c_sCOPYRIGHT = "Copyright 2016 by Julie Green";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double dFirstNumber;
                double dSecondNumber;
                double dResult;

                if (double.TryParse(txtFirstNumber.Text, out dFirstNumber))
                {
                    if (double.TryParse(txtSecondNumber.Text, out dSecondNumber))
                    {
                        if (chkMaxNumber.Checked && dFirstNumber > 100)
                        {
                            MessageBox.Show("First number must not be greater than 100.");
                            txtFirstNumber.Focus();
                            return;
                        }

                        if (chkMaxNumber.Checked && dSecondNumber > 100)
                        {
                            MessageBox.Show("Second number must not be greater than 100.");
                            txtSecondNumber.Focus();
                            return;
                        }

                        if (radAdd.Checked)
                        {
                            dResult = dFirstNumber + dSecondNumber;
                            txtResult.Text = dResult.ToString("n1");
                        }
                        else if (radSubtract.Checked)
                        {
                            dResult = dFirstNumber - dSecondNumber;
                            txtResult.Text = dResult.ToString("n1");
                        }
                        else if (radMultiply.Checked)
                        {
                            dResult = dFirstNumber * dSecondNumber;
                            txtResult.Text = dResult.ToString("n1");
                        }
                        else if (radioDivide.Checked)
                        {
                            dResult = dFirstNumber / dSecondNumber;
                            txtResult.Text = dResult.ToString("n1");
                        }
                        else
                        {
                            MessageBox.Show("You much check one of the operation buttons.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Second Number contains invalid data.");
                        txtSecondNumber.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("First Number contains invalid data.");
                    txtFirstNumber.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
