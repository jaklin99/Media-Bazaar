using MySql.Data.MySqlClient;
using Renci.SshNet.Messages.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms.VisualStyles;

namespace ProjectMB
{
    static class DatabaseFunctions
    {
        private static readonly string ConnectionString =
            "server=studmysql01.fhict.local;database=dbi428428;uid=dbi428428;password=spiderMan2000;";
        #region CRUD_User
        public static bool GetAllUsers()
        {
            string query = "Select * from people as p join working_days as wd on p.username = wd.username";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    List<User> results = new List<User>();
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        int id = Int32.Parse(dataReader[0].ToString());
                        string username = dataReader[1].ToString();
                        string firstName = dataReader[2].ToString();
                        string lastName = dataReader[3].ToString();
                        string email = dataReader[4].ToString();
                        string phoneNumber = dataReader[5].ToString();
                        PersonPosition position =
                            (PersonPosition)Enum.Parse(typeof(PersonPosition), dataReader[6].ToString(), true);
                        double salary = Double.Parse(dataReader[7].ToString());
                        Department department = new Department(dataReader[8].ToString());
                        ShiftType shiftType =
                            (ShiftType)Enum.Parse(typeof(ShiftType), dataReader[11].ToString(), true);
                        bool[] days = new bool[7];
                        for (int i = 0; i < 7; i++)
                        {
                            days[i] = bool.Parse(dataReader[i + 12].ToString());
                        }

                        User user = new User(username, firstName, lastName, email, position, salary, shiftType,
                            days, department, id, phoneNumber);
                        results.Add(user);
                        //MessageBox.Show(user.ToString());
                    }

                    conn.Close();
                    Users.users.Clear();
                    Users.users.AddRange(results);
                }
            }
            catch (Exception)
            {
                throw new NoConnectionException();
            }

            return true;
        }
        public static string PasswordByUsername(string username)
        {
            if (username != "")
            {
                try
                {
                    string query = "select password from users where username = @username";
                    using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", username);
                        Object obj = cmd.ExecuteScalar();
                        conn.Close();
                        return obj.ToString();
                    }
                }
                catch (Exception)
                {
                    throw new NoConnectionException();
                }
            }
            else
            {
                throw new NotExistingException();
            }
        }
        public static void AddUser(User user, bool manager = false)
        {
            if (user != null)
            {
                try
                {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {       
                    string query =
                            "insert into users (`username`, `first_time_verification_key`) VALUES (@username, @verificationKey);";
                        if (manager) query =
                             "insert into users (`username`, `password`) VALUES (@username, @verificationKey);";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@verificationKey", user.GenerateVerificationKey());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    query =
                           "Insert into people (`username`, `first_name`, `last_name`, `email`, `position`, `salary`, `department`) values (@username, @first_name, @last_name, @email, @position, @salary, @department);";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", user.LastName);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@salary", user.Salary);
                    cmd.Parameters.AddWithValue("@department", user.UserDepartment.Name);
                    cmd.Parameters.AddWithValue("@position", user.Position.ToString());
                        //MessageBox.Show(user.Position.ToString());
                        conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    query =
                            "insert into working_days (`username`, `shift`, `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday`, `Saturday`, `Sunday`) values (@username, @shift, @monday, @tuesday, @wednesday, @thursday, @friday, @saturday, @sunday);";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@shift", user.ShiftTypeU.ToString());
                    cmd.Parameters.AddWithValue("@monday", user.WorkingDays[0]);
                    cmd.Parameters.AddWithValue("@tuesday", user.WorkingDays[1]);
                    cmd.Parameters.AddWithValue("@wednesday", user.WorkingDays[2]);
                    cmd.Parameters.AddWithValue("@thursday", user.WorkingDays[3]);
                    cmd.Parameters.AddWithValue("@friday", user.WorkingDays[4]);
                    cmd.Parameters.AddWithValue("@saturday", user.WorkingDays[5]);
                    cmd.Parameters.AddWithValue("@sunday", user.WorkingDays[6]);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                }
                catch (Exception)
                {
                    throw new NoConnectionException();
                }
            }
            else
            {
                throw new NotExistingException();
            }
        }
        public static void UpdateUser(User user)
        {
            if (user != null)
            {

                string query =
                    "update people set first_name = @firstname, last_name = @lastname, email = @email, salary = @salary, department = @department WHERE username = @username;";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@firstname", user.FirstName);
                        cmd.Parameters.AddWithValue("@lastname", user.LastName);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@salary", user.Salary);
                        cmd.Parameters.AddWithValue("@department", user.UserDepartment.Name);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        query =
                            "update working_days set shift = @shift, Monday = @monday, Tuesday = @tuesday, Wednesday = @wednesday, Thursday = @thursday, Friday = @friday, Saturday = @saturday, Sunday = @sunday where username = @username;";

                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@shift", user.ShiftTypeU.ToString());
                        cmd.Parameters.AddWithValue("@monday", user.WorkingDays[0]);
                        cmd.Parameters.AddWithValue("@tuesday", user.WorkingDays[1]);
                        cmd.Parameters.AddWithValue("@wednesday", user.WorkingDays[2]);
                        cmd.Parameters.AddWithValue("@thursday", user.WorkingDays[3]);
                        cmd.Parameters.AddWithValue("@friday", user.WorkingDays[4]);
                        cmd.Parameters.AddWithValue("@saturday", user.WorkingDays[5]);
                        cmd.Parameters.AddWithValue("@sunday", user.WorkingDays[6]);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    throw new NoConnectionException();
                }
            }
            else
            {
                throw new NotExistingException();
            }
        }
        public static void RemoveUser(User user)
        {
            if (user != null)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                    {
                        string query = "DELETE FROM people WHERE username=@username;";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        query = "DELETE FROM users WHERE username=@username;";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        query = "DELETE FROM working_days WHERE username=@username;";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    throw new NoConnectionException();
                }
            }
            else
            {
                throw new NotExistingException();
            }
        }
        #endregion
        #region CRUD_Product
        public static bool GetAllProducts()
        {
            string query = "Select * from products;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    List<Product> results = new List<Product>();
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string id = dataReader[0].ToString();
                        string name = dataReader[1].ToString();
                        ProductCategory productCategory =
                            (ProductCategory)Enum.Parse(typeof(ProductCategory), dataReader[2].ToString(), true);
                        string price = dataReader[3].ToString();
                        string quantity = dataReader[4].ToString();
                        bool stockRequest = (bool)dataReader[5];

                        Product product = new Product(name, productCategory, double.Parse(price), int.Parse(quantity), stockRequest, int.Parse(id));
                        results.Add(product);
                    }

                    conn.Close();
                    Products.products.Clear();
                    Products.products.AddRange(results);
                }
            }
            catch (Exception)
            {
                throw new NoConnectionException();
            }

            return true;
        }
        public static bool GetAllProductsByCategory(ProductCategory category)
        {
            string query = "Select * from products where Category = @category;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    List<Product> results = new List<Product>();
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string id = dataReader[0].ToString();
                        string name = dataReader[1].ToString();
                        ProductCategory productCategory =
                            (ProductCategory)Enum.Parse(typeof(ProductCategory), dataReader[2].ToString(), true);
                        string price = dataReader[3].ToString();
                        string quantity = dataReader[4].ToString();
                        bool stockRequest = (bool) dataReader[5];

                        Product product = new Product(name, productCategory, double.Parse(price), int.Parse(quantity), stockRequest, int.Parse(id));
                        results.Add(product);
                    }

                    conn.Close();
                    Products.products.Clear();
                    Products.products.AddRange(results);
                }
            }
            catch (Exception)
            {
                throw new NoConnectionException();
            }

            return true;
        }
        public static void AddProduct(Product product)
        {
            if (product != null)
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    string query =
                        "Insert into products (`Name`, `Category`, `Price`, `Quantity`, `stockRequest`) values (@name, @category, @price, @quantity, @stockRequest);";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@category", product.Category + 1);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("@stockRequest", product.StockRequest);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            {
                throw new NotExistingException();
            }
        }
        public static void UpdateProduct(Product product)
        {
            if (product != null)
            {
                string query =
                    "update products set Name = @name, Category = @category, Price = @price, Quantity = @quantity, stockRequest = @stockRequest WHERE id = @id;";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", product.id);
                        cmd.Parameters.AddWithValue("@name", product.Name);
                        cmd.Parameters.AddWithValue("@category", product.Category + 1);
                        cmd.Parameters.AddWithValue("@price", product.Price);
                        cmd.Parameters.AddWithValue("@quantity", product.Quantity);
                        cmd.Parameters.AddWithValue("@stockRequest", product.StockRequest);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    throw new NoConnectionException();
                }
            }
            else
            {
                throw new NotExistingException();
            }
        }
        public static void RemoveProduct(Product product)
        {
            if (product != null)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                    {
                        MySqlCommand cmd = null;
                        string query = "DELETE FROM products WHERE Name=@name;";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@name", product.Name);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    throw new NoConnectionException();
                }
            }
            else
            {
                throw new NotExistingException();
            }
        }
        #endregion
        #region CRUD_Department
        public static bool GetAllDepartments()
        {
            string query = "select departmentName from departments";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    List<Department> results = new List<Department>();
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string name = dataReader[0].ToString();
                        Department department = new Department(name);
                        results.Add(department);
                    }
                    conn.Close();
                    Departments.departments.Clear();
                    Departments.departments.AddRange(results);

                }
            }
            catch (Exception)
            {
                throw new NoConnectionException();
            }
            return true;
        }
        public static void AddDepartment(Department department)
        {
            if (department != null)
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    string query = "insert into departments(`departmentName`) values (@name);";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", department.Name);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void UpdateDepartment(Department department, string oldName)
        {
            if (department != null)
            {
                try
                {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    string query = "update departments set departmentName = @name where departmentName = @oldName";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", department.Name);
                    cmd.Parameters.AddWithValue("@oldName", oldName);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                }
                catch (Exception)
                {
                    throw new NoConnectionException();
                }
            }
        }
        public static void RemoveDepartment(Department department)
        {
            if (department != null)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                    {
                        string query = "select count(id) from people where department = @name;";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@name", department.Name);
                        conn.Open();
                        Object obj = cmd.ExecuteScalar();
                        conn.Close();
                        if (int.Parse(obj.ToString()) == 0)
                        {
                            query = "DELETE FROM departments WHERE departmentName = @name;";
                            MySqlCommand cmd_del = new MySqlCommand(query, conn);
                            cmd_del.Parameters.AddWithValue("@name", department.Name);
                            conn.Open();
                            cmd_del.ExecuteNonQuery();
                            conn.Close();
                        }
                        else
                        {
                            throw new UsersInDepartmentException();
                        }
                    }
                }
                catch (UsersInDepartmentException)
                {
                    throw new UsersInDepartmentException();
                }
                catch (Exception)
                {
                    throw new NoConnectionException();
                }
            }
            else
            {
                throw new NotExistingException();
            }
        }
        #endregion
    }
}
