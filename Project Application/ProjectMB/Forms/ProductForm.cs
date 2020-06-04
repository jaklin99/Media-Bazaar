using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMB
{
    public partial class ProductForm : Form
    {
        Product _productToBeEdited;
        private bool _editProduct;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        public ProductForm(Product product)
        {
            InitializeComponent();
            _productToBeEdited = product;
            nameTb.Text = product.Name;
            priceTb.Text = product.Price.ToString();
            quantityTb.Text = product.Quantity.ToString();
            categoryCb.Text = product.Category.ToString();
            stockCbx.Checked = product.StockRequest;
            _editProduct = true;
            titleLbl.Text = "Edit Product";
            this.removeBtn.Enabled = true;
        }

        public ProductForm()
        {
            InitializeComponent();
            _editProduct = false;
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            categoryCb.Items.Clear();
            categoryCb.Items.Add("Category");
            foreach (var item in Enum.GetValues(typeof(ProductCategory))
                                    .Cast<ProductCategory>()
                                    .ToList())
            {
                categoryCb.Items.Add(item.ToString());
            }
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_SLIDE);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
           
                if (!string.IsNullOrWhiteSpace(nameTb.Text) && !string.IsNullOrWhiteSpace(priceTb.Text) && !string.IsNullOrWhiteSpace(quantityTb.Text))
                {

                    if (categoryCb.SelectedIndex > 0)
                    {
                        string productName = nameTb.Text;
                       
                        double productPrice = double.Parse(priceTb.Text);
                        int productQuantity = int.Parse(quantityTb.Text);
                        bool stockRequest = stockCbx.Checked;
                        ProductCategory type = (ProductCategory)Enum.Parse(typeof(ProductCategory), categoryCb.Text, true);

                        if (_editProduct)
                        {
                            _productToBeEdited.Name = productName;
                            _productToBeEdited.Price = productPrice;
                            _productToBeEdited.Quantity = productQuantity;
                            _productToBeEdited.Category = type;
                            _productToBeEdited.StockRequest = stockRequest;
                            Products.UpdateProduct(_productToBeEdited);
                        }
                        else
                        {
                            Product newProduct = new Product(productName, type, productPrice, productQuantity, stockRequest);
                            Products.AddProduct(newProduct);
                        }
                        DatabaseFunctions.GetAllProducts();
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Choose type!");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the empty fields!");
                }
            
          
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Products.RemoveProduct(_productToBeEdited);
            }
            catch (NoConnectionException)
            {
                MessageBox.Show("Connection unsuccessful, please restart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotExistingException)
            {
                MessageBox.Show("Product is non-existent, please restart", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        private void stockCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (stockCbx.Checked)
            {
                stockCbx.BackColor = Color.Green;
            }
            else
            {
                stockCbx.BackColor = Color.Red;
            }
        }
    }
}
