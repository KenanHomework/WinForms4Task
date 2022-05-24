using System.Text.Json;

namespace WinForms4
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public List<Product> Products = new List<Product>();


        public void CheckEnebleds()
        {
            bool cond = lbx_products.Items.Count <= 0 ? false : true;
            btn_remove.Enabled = cond;
            btn_edit.Enabled = cond;
            btn_clear.Enabled = cond;
        }

        public void SaveToFile()
            => File.WriteAllText("products.json", JsonSerializer.Serialize<List<Product>>(Products));

        private void lbx_products_SelectedIndexChanged(object sender, EventArgs e) => CheckEnebleds();

        private void btn_add_Click(object sender, EventArgs e)
        {
            ProductViewer productViewer = new ProductViewer();
            if (productViewer.ShowDialog() == DialogResult.OK)
            {
                Products.Add(productViewer.product);
                lbx_products.Items.Clear();
                Products.ForEach(x => lbx_products.Items.Add(x));
                SaveToFile();
            }
            CheckEnebleds();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ProductViewer productViewer = new ProductViewer(Products[lbx_products.SelectedIndex]);
            if (productViewer.ShowDialog() == DialogResult.OK)
            {
                Products[lbx_products.SelectedIndex] = productViewer.product;
                lbx_products.Items[lbx_products.SelectedIndex] = productViewer.product;
                SaveToFile();
            }
            CheckEnebleds();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                //int index = lbx_products.SelectedIndex;
                Products.RemoveAt(lbx_products.SelectedIndex);
                lbx_products.Items.RemoveAt(lbx_products.SelectedIndex);
                SaveToFile();
            }
            CheckEnebleds();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Products.Clear();
            lbx_products.Items.Clear();
            SaveToFile();
            CheckEnebleds();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            if (File.Exists("products.json"))
            {
                try
                {
                    Products = JsonSerializer.Deserialize<List<Product>>(File.ReadAllText("products.json"));
                }
                catch (Exception)
                {
                    // if throw exception mean "product.josn" is empty
                }
                Products.ForEach(p => lbx_products.Items.Add(p));
            }
            else
                File.Create("products.json");
        }
    }
}