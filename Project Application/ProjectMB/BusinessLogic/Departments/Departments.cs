using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    static class Departments
    {
        public static List<Department> departments = new List<Department>();

        public static Department DepartmentByName(string name)
        {
            foreach (var item in departments)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            throw new NotExistingException();
        }
        public static void AddDepartment(string name)
        {
            try
            {
                departments.Add(new Department(name));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void RemoveDepartment()
        {
            try
            {
                for (int i = 0; i < departments.Count; i++)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void UpdateDepartment()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
