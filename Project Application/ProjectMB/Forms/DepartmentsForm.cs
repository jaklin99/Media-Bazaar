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
    public partial class DepartmentsForm : Form
    {
        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        public DepartmentsForm()
        {
            InitializeComponent();
            departmentsLb.SelectedValueChanged += new EventHandler(DepartmentLb_SelectedValueChanged);
            Timer timer = new Timer
            {
                Interval = 2000
            };
            timer.Enabled = true;
            timer.Tick += OnTimerEvent;
        }
        private void OnTimerEvent(object sender, EventArgs e)
        {
            departmentsLb.Items.Clear();
            foreach (var item in Departments.departments)
            {
                departmentsLb.Items.Add(item.Name);
            }
        }
        protected void DepartmentLb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DepartmentForm dF = new DepartmentForm(Departments.departments[departmentsLb.SelectedIndex]);
                dF.Show();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }
        private void addDepartmentBtn_Click(object sender, EventArgs e)
        {
            DepartmentForm dF = new DepartmentForm();
            dF.Show();
        }

        private void searchDepartmentBtn_Click(object sender, EventArgs e)
        {
            SearchForm sF = new SearchForm(ManageType.DEPARTMENT);
            sF.Show();
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
           

            try
            {
                DatabaseFunctions.GetAllDepartments();
                foreach (var item in Departments.departments)
                {
                    departmentsLb.Items.Add(item.Name);
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

        private void DepartmentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
