using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txtAmountDue.Text);
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;

            while(amount >= 25)
            {
                amount -= 25;
                quarters++;
            }
            while (amount >= 10)
            {
                amount -= 10;
                dimes++;
            }
            while (amount >= 5)
            {
                amount -= 5;
                nickels++;
            }
            while (amount >= 1)
            {
                amount -= 1;
                pennies++;
            }
            txtQuarters.Text = quarters.ToString();
            txtDimes.Text = dimes.ToString();
            txtNickels.Text = nickels.ToString();
            txtPennies.Text = pennies.ToString();
            
            txtAmountDue.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtAmountDue_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int amount = int.Parse(txtAmountDue.Text);
                int quarters = 0;
                int dimes = 0;
                int nickels = 0;
                int pennies = 0;

                while (amount >= 25)
                {
                    amount -= 25;
                    quarters++;
                }
                while (amount >= 10)
                {
                    amount -= 10;
                    dimes++;
                }
                while (amount >= 5)
                {
                    amount -= 5;
                    nickels++;
                }
                while (amount >= 1)
                {
                    amount -= 1;
                    pennies++;
                }
                txtQuarters.Text = quarters.ToString();
                txtDimes.Text = dimes.ToString();
                txtNickels.Text = nickels.ToString();
                txtPennies.Text = pennies.ToString();

                txtAmountDue.Focus();
            }
        
        }
    }
}
