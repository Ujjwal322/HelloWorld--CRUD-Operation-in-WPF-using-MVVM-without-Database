using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CRUD.Model
{
    class EmployeeService
    {
        public int AddEmployee(Employee employee)
        {
            Employee emp = new Employee();

            employee.FirstName = emp.FirstName;
            employee.LastName = emp.LastName;
            employee.EmailID = emp.EmailID;
            employee.Password = emp.Password;
            employee.ConfirmPassword = emp.ConfirmPassword;
            employee.Address = emp.Address;
            //employee.Gender = emp.Gender;
            //employee.Language = emp.Language;

            Console.WriteLine("Success");
            return 1;
        }
       
        //MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radMale.Content.ToString() + "," + radFemale.Content.ToString() + ", " + checkEnglish.Content.ToString() + ", " + checkHindi.Content.ToString() + ", " + checkFrench.Content.ToString());
    }
   

}

