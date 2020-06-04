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
    public partial class SearchForm : Form
    {
        ManageType type;
        User[] foundUsers;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        public SearchForm(ManageType type)
        {
            InitializeComponent();
            
            resultsLb.SelectedValueChanged += new EventHandler(resultsLb_SelectedValueChanged);
            this.type = type;
        }
        private void resultsLb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (type==ManageType.EMPLOYEE)
                {
                    EmployeeForm employeeForm = new EmployeeForm(foundUsers[resultsLb.SelectedIndex]);
                    employeeForm.Show();
                }
                else
                {
                    ProductForm productForm = new ProductForm(Products.FindProduct(resultsLb.SelectedItem.ToString()));
                    productForm.Show();
                }
                resultsLb.Items.Clear();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            
        }
        private void SearchProductForm_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_SLIDE);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            resultsLb.Items.Clear();
            string input = searchTb.Text;
            searchTb.Clear();
            foundUsers = Users.FindUsers(input);
            if (type==ManageType.EMPLOYEE)
            {
                foreach (var item in foundUsers)
                {
                    resultsLb.Items.Add(item.ToString());                 
                }
            }
            else if (type==ManageType.PRODUCT)
            {
                for (int i = 0; i < Products.products.Count; i++)
                {
                    if (Products.products[i].Name.Contains(input))
                    {
                        resultsLb.Items.Add(Products.products[i].Name);
                    }
                }
            }
            else
            {
                for (int i = 0; i < Departments.departments.Count; i++)
                {
                    if (Departments.departments[i].Name.Contains(input))
                    {
                        resultsLb.Items.Add(Departments.departments[i].Name);
                    }
                }
            }
           
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
