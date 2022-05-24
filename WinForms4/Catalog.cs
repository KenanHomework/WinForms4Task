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
        private void btn_add_Click(object sender, EventArgs e)
        {
            ProductViewer productViewer = new ProductViewer();
            if (productViewer.ShowDialog() == DialogResult.OK)
            {
                Products.Add(productViewer.product);
                lbx_products.Items.Clear();
                Products.ForEach(x => lbx_products.Items.Add(x));
            }
        }
    }
}