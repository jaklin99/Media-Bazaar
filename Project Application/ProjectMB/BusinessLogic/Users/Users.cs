using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectMB
{
     class Users
    {
        public static List<User> users = new List<User>();
        public static List<User> requestedUsers = new List<User>();
        public static string Department = "";
        public static bool admin = false;
        
        public static User FindUser(string username)
        {
            foreach (var item in users)
            {
                if (item.Username == username)
                {
                    return item;
                }
            }
            return null;
        }
        public static User FindUser(int id)
        {
            foreach (var item in users)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static int LastGenUsernameId()
        {
         List<User> usersResults = new List<User>();   
            foreach (var item in users)
            {
                if (item.Username.Contains("mbemp"))
                {
                    usersResults.Add(item);
                }
            }

            string lastUser = usersResults[usersResults.Count - 1].Username;
            int returnId = int.Parse(lastUser.Substring(5, lastUser.Length - 5));
            return returnId;
        }
        public static User[] FindUsers(string lastName)
        {           
            return users.FindAll(User => User.LastName.ToLower().Contains(lastName.ToLower())).ToArray();
        }

        public static void AddUser(User user, bool manager = false) 
        {
            DatabaseFunctions.AddUser(user, manager);
            DatabaseFunctions.GetAllUsers();
        }
        public static void UpdateUser(User user)
        {
            DatabaseFunctions.UpdateUser(user);
            DatabaseFunctions.GetAllUsers();
        }
        public static void RemoveUser(User user)
        {
            DatabaseFunctions.RemoveUser(user);
            DatabaseFunctions.GetAllUsers();
        }
        public static void GetUsers(int role, string department)
        {
            requestedUsers.Clear();
            if (role < 6)
            {

                foreach (var item in users)
                {
                    if (item.UserDepartment.Name == department || department == "All Departments")
                    {
                        if (item.Position == (PersonPosition)(role-1))
                        {
                            requestedUsers.Add(item);
                        }
                    }
                }
            }
            else if (role == 6)
            {
                foreach (var item in users)
                {
                    if (item.UserDepartment.Name == department || department == "All Departments")
                    {
                        if (item.Position != PersonPosition.Admin && item.Position != PersonPosition.Manager)
                        {
                            requestedUsers.Add(item);
                        }
                    }
                }
            }
            else if (role == 7)
            {
                foreach (var item in users)
                {
                    if (item.UserDepartment.Name == department || department == "All Departments")
                    {
                        requestedUsers.Add(item);
                    }
                }
            }
            else
            {
                throw new NotExistingException();
            }
        }
    }
}
