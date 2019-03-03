using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSTax
{
    public partial class Form1 : Form
    {
        double iTax, iSubTotal, iTotal;

        private void resetButton_Click(object sender, EventArgs e)
        {
            txtTax.BackColor = Color.White;
            txtSubTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtQuantity.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to quit", "Sales Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                totalButton_Click(sender, e);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            cTax cost = new cTax();

            cost.item1 = double.Parse(txtQuantity.Text);

            iSubTotal = cost.GetAmount();
            iTax = cost.cFindTax(iSubTotal);

            iTotal = iSubTotal + iTax;

            txtTax.Text = String.Format("{0:C}", iTax);
            txtSubTotal.Text = String.Format("{0:C}", iSubTotal);
            txtTotal.Text = String.Format("{0:C}", iTotal);

            txtTax.BackColor = Color.Azure;
        }
    }
}
