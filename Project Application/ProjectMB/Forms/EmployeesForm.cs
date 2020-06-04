using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMB
{
    public partial class EmployeesForm : Form
    {

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        public EmployeesForm()
        {
            InitializeComponent();
            //Users.Change += new EventHandler<EventArgs>(OnTimerEvent);
            Timer timer = new Timer
            {
                Interval = 5000
            };
            timer.Enabled = true;
            timer.Tick += OnTimerEvent;
        }
        private void OnTimerEvent(object sender, EventArgs e)
        {
            employeesLv.Items.Clear();
            foreach (var item in Users.requestedUsers)
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());
                lvi.SubItems.Add(item.FirstName);
                lvi.SubItems.Add(item.LastName);
                lvi.SubItems.Add(item.Email);
                lvi.SubItems.Add(item.PhoneNumber);
                lvi.SubItems.Add(item.Position.ToString());
                lvi.SubItems.Add(item.Salary.ToString("C2", CultureInfo.CurrentCulture));
                lvi.SubItems.Add(item.UserDepartment.Name);
                employeesLv.Items.Add(lvi);
            }
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseFunctions.GetAllUsers();
                DatabaseFunctions.GetAllDepartments();

                employeesLv.Items.Clear();
                foreach (var item in Users.users)
                {
                    ListViewItem lvi = new ListViewItem(item.ID.ToString());
                    lvi.SubItems.Add(item.FirstName);
                    lvi.SubItems.Add(item.LastName);
                    lvi.SubItems.Add(item.Email);
                    lvi.SubItems.Add(item.PhoneNumber);
                    lvi.SubItems.Add(item.Position.ToString());
                    lvi.SubItems.Add(item.Salary.ToString("C2", CultureInfo.CurrentCulture));
                    lvi.SubItems.Add(item.UserDepartment.Name);
                    employeesLv.Items.Add(lvi);
                }
                departmentCb.Items.Clear();
                departmentCb.Items.Add("Department");
                departmentCb.Items.Add("All Departments");
                departmentCb.SelectedIndex = 0;
                foreach (var item in Departments.departments)
                {
                    departmentCb.Items.Add(item.Name);
                }
                roleCb.SelectedIndex = 0;
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
            SearchForm searchForm = new SearchForm(ManageType.EMPLOYEE);
            searchForm.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeesLv_Click(object sender, EventArgs e)
        {
            try
            {
                User user = Users.FindUser(int.Parse(employeesLv.SelectedItems[0].SubItems[0].Text));
                if (user != null)
                {
                    EmployeeForm employeeForm = new EmployeeForm(user);
                    employeeForm.Show();
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

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (departmentCb.SelectedIndex > 0 && roleCb.SelectedIndex > 0)
            {
                int role = roleCb.SelectedIndex;
                string department = departmentCb.SelectedItem.ToString();
                Users.GetUsers(role, department);
            }
            else
            {
                MessageBox.Show("Choose valid options, please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);

        }
    }
}
