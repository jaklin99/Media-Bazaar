using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjectMB
{
    public partial class ProductsForm : Form
    {

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        private ProductCategory currentCategory;
        bool allCategories = true;
        public ProductsForm()
        {
            InitializeComponent();
            Products.productChanged += Products_productChanged;
            Products.productAdded += Products_productAdded;
            Products.productRemoved += Products_productRemoved;
        }

        private void Products_productRemoved(Product product)
        {
            if (allCategories || product.Category == currentCategory)
            {
                foreach (ListViewItem item in productsLw.Items)
                {
                    if (int.Parse(item.SubItems[0].Text) == product.id)
                    {
                        productsLw.Items.Remove(item);
                        break;
                    }
                }
            }
        }

        private void Products_productAdded(Product product)
        {
            if (allCategories || product.Category == currentCategory)
            {
                AddItem(product);
            }
        }
        private void Products_productChanged(Product product)
        {
            if (allCategories || product.Category == currentCategory)
            {
                foreach (ListViewItem item in productsLw.Items)
                {
                    if (int.Parse(item.SubItems[0].Text) == product.id)
                    {
                        productsLw.Items.Remove(item);
                        AddItem(product);
                        break;
                    }
                }
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.addBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.addBtn.FlatStyle = FlatStyle.Flat;
            this.searchBtn.BackColor = Color.FromArgb(5, 179, 245);
            this.searchBtn.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(193, 162, 254);
            try
            {
                DatabaseFunctions.GetAllProducts();
                productsLw.Items.Clear();
                foreach (var item in Products.products)
                {
                    AddItem(item);
                }
            }
            catch (NoConnectionException)
            {
                MessageBox.Show("Connection unsuccessful, please restart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotExistingException)
            {
                MessageBox.Show("Department is non-existent, please restart", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_SLIDE);

        }



        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchProductForm = new SearchForm(ManageType.PRODUCT);
            searchProductForm.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProductForm newProductForm = new ProductForm();
            newProductForm.Focus();
            newProductForm.Show();
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        private void productsLw_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Product product = Products.FindProduct(int.Parse(productsLw.SelectedItems[0].SubItems[0].Text));
                if (product != null)
                {
                    ProductForm productForm = new ProductForm(product);
                    productForm.Focus();
                    productForm.Show();
                }
                else
                {
                    MessageBox.Show("Couldn't find the user, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void AddItem(Product product)
        {
            ListViewItem lvi = new ListViewItem(product.id.ToString());
            lvi.SubItems.Add(product.Name);
            lvi.SubItems.Add(product.Category.ToString());
            lvi.SubItems.Add(product.Price.ToString("C2", CultureInfo.CurrentCulture));
            lvi.SubItems.Add(product.Quantity.ToString());

            if (product.StockRequest)
            {
                lvi.SubItems.Add("Yes");
            }
            else
            {
                lvi.SubItems.Add("No");
            }

            productsLw.Items.Add(lvi);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (categoryCb.SelectedIndex > -1)
            {
                if (categoryCb.SelectedIndex == 0)
                {
                    allCategories = true;
                    productsLw.Items.Clear();
                    foreach (var item in Products.products)
                    {
                        AddItem(item);
                    }
                }
                else
                {
                    productsLw.Items.Clear();
                    currentCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), (categoryCb.Text), true);
                    foreach (var item in Products.FindProducts(currentCategory))
                    {
                        AddItem(item);
                    }
                    allCategories = false;
                }
            }
            else
            {
                MessageBox.Show("No category selected, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
