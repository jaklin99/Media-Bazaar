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
   
    public partial class DepartmentForm : Form
    {
        Department _departmentToBeEdited;
        private bool _editDepartment;
        private string departmentOldName = "";

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);
       
        public DepartmentForm(Department department)
        {
            InitializeComponent();
            _departmentToBeEdited = department;
            NameTb.Text = department.Name;
            departmentOldName = department.Name;
            _editDepartment = true;
            removeBtn.Enabled = true;

        }
        public DepartmentForm()
        {
            InitializeComponent();
            _editDepartment = false;

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(NameTb.Text))
                {
                    string departmentName = NameTb.Text;
                    if (_editDepartment)
                    {
                        _departmentToBeEdited.Name = departmentName;
                        DatabaseFunctions.UpdateDepartment(_departmentToBeEdited, departmentOldName);
                    }
                    else
                    {
                        Department newDepartment = new Department(departmentName);
                        DatabaseFunctions.AddDepartment(newDepartment);
                    }
                    DatabaseFunctions.GetAllDepartments();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fill in the empty field.");
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
           
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseFunctions.RemoveDepartment(_departmentToBeEdited);
                DatabaseFunctions.GetAllDepartments();
                this.Close();
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
            catch (UsersInDepartmentException)
            {
                MessageBox.Show("There are still employees in that department", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_SLIDE);
        }

        private void DepartmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }
    }
}
