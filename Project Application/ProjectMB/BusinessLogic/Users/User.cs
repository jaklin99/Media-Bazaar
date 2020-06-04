using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    public class User
    {
        public User(string username, string firstName, string lastName, string email, PersonPosition position, double salary, ShiftType shiftType, bool[] workingDays, Department department, int id, string phoneNumber)
        {
            this.ID = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Position = position;
            Salary = salary;
            ShiftTypeU = shiftType;
            WorkingDays = workingDays;
            UserDepartment = department;
            PhoneNumber = phoneNumber;
        }
        public User(string username, string firstName, string lastName, string email, PersonPosition position, double salary, ShiftType shiftType, bool[] workingDays, Department department, int id)
                 {
                     this.ID = id;
                     Username = username;
                     FirstName = firstName;
                     LastName = lastName;
                     Email = email;
                     Position = position;
                     Salary = salary;
                     ShiftTypeU = shiftType;
                     WorkingDays = workingDays;
            UserDepartment = department;
                 }
        public User(string firstName, string lastName, string email, PersonPosition position, double salary, ShiftType shiftType, bool[] workingDays, Department department)
        {
            try
            {
                Username = GenerateUsername();

            }
            catch (FormatException)
            {
                throw new UsernameErrorException();
            }
            catch (IOException)
            {
                throw new IOException();
            }
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Position = position;
            Salary = salary;
            ShiftTypeU = shiftType;
            WorkingDays = workingDays;
            UserDepartment = department;
        }
        public int ID { get; private set; }
        private static int _idSeed= 9999;

        public string Username { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public PersonPosition Position { get; set; }
        public double Salary { get; set; }
        public ShiftType ShiftTypeU { get; set; }
        public bool[] WorkingDays { get; set; }
        public Department UserDepartment { get; set; }

        public string PhoneNumber { get;private set; }


        private static Random _random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
        public string GenerateVerificationKey()
        {            
          return RandomString(12);           
        }
        public static string GenerateUsername()
        {
            string genUsername = "";
            StreamReader sr = null;
           
                FileStream fs = null;

                fs = new FileStream("idSeeder", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
               
                string input = sr.ReadToEnd();
                sr.Close();
                _idSeed = int.Parse(input);
                genUsername = "mbemp" + _idSeed;
                _idSeed++;
                string[] line = {_idSeed.ToString()};
                File.WriteAllLines("idSeeder", line);
                if (genUsername != "")
            {
                return genUsername;
            }
            else
            {
                throw new UsernameErrorException();
            }
        }

        public override string ToString()
        {
            return $"{FirstName}\t{LastName}\t{Email}\t{Salary.ToString("C2", CultureInfo.CurrentCulture)}\t{UserDepartment.Name}\t{Position}";
        }
    }



}
