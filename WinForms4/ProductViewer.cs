using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms4
{
    public partial class ProductViewer : Form
    {
        public ProductViewer()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public Product product = new Product();

        public bool CName = false;
        public bool CCountry = false;
        public bool CCost = false;

        public void CheckTexBox(ref TextBox tbx, ref Label lbl, ref bool control, string regex)
        {
            if (tbx.Text.Length > 2)

                if (new Regex(regex).IsMatch(tbx.Text))
                {
                    control = true;
                    lbl.ForeColor = Color.Black;
                    tbx.BackColor = Color.White;
                }
                else
                {
                    control = false;
                    lbl.ForeColor = Color.Red;
                    tbx.BackColor = Color.Red;
                }
            else
            {

                control = false;
                lbl.ForeColor = Color.Red;
                tbx.BackColor = Color.Red;
            }
        }

        public void CheckTexBox(ref MaskedTextBox tbx, ref Label lbl, ref bool control)
        {
            if (tbx.Text.Length > 2)
            {
                control = true;
                lbl.ForeColor = Color.Black;
                tbx.BackColor = Color.White;
            }
            else
            {

                control = false;
                lbl.ForeColor = Color.Red;
                tbx.BackColor = Color.Red;
            }
        }

        public bool CheckFields()
        {
            if (CName)
                if (CCost)
                    if (CCountry)
                        return true;
            return false;
        }

        string MTrim(string txt, string trimChars)
        {
            StringBuilder sb = new StringBuilder();
            txt.ToList().ForEach(delegate (Char ch)
            {
                if (!trimChars.Contains(ch))
                    sb.Append(ch);
            });
            return sb.ToString();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                product.Name = tbx_name.Text;
                product.Country = tbx_country.Text;
                product.Cost = Convert.ToInt32(MTrim(mtbx_coast.Text, " _()-"));
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Please Correctly write Filename!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void tbx_name_TextChanged(object sender, EventArgs e)
            => CheckTexBox(ref tbx_name, ref lbl_name, ref CName, "^([A-Za-z]+([ ]?[a-z]?['-]?[A-Za-z]+)*)$");

        private void tbx_country_TextChanged(object sender, EventArgs e)
            => CheckTexBox(ref tbx_country, ref lbl_country, ref CCountry, "^([A-Za-z]+([ ]?[a-z]?['-]?[A-Za-z]+)*)$");

        private void mtbx_coast_TextChanged(object sender, EventArgs e)
                    => CheckTexBox(ref mtbx_coast, ref lbl_coast, ref CCost);

        private void btn_cancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    }
}
