using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace CRUD
{
    /// <summary>
    /// Interaction logic for Example.xaml
    /// </summary>
    public partial class Example : Window
    {
        public Example()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee();

            employee.FirstName = textBoxFirstName.Text;
            employee.LastName = textBoxLastName.Text;
            employee.EmailId = textBoxEmail.Text;
            employee.Password = passwordBox1.Password;
            employee.ConfirmPassword = passwordBoxConfirm.Password;
            employee.Address = textBoxAddress.Text;
            employee.Country = cblCountry.Text;

            //employee.Gender = Convert.ToBoolean(radMale.Content.ToString());
            //employee.Gender = radFemale.Content.ToString();
            if (employee.Gender = (radFemale.IsChecked == true))
            {
                radFemale.Content.ToString();
                //MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radFemale.Content.ToString());

            }
            else
            {
                radMale.Content.ToString();
                //MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radMale.Content.ToString());

            }

            //if(employee.Language = (checkEnglish.IsChecked == true))
            //{
            //    //checkEnglish.Content.ToString();
            //    MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radMale.Content.ToString() + "," + radFemale.Content.ToString() + "," + checkEnglish.Content.ToString());

            //}
            //else if(employee.Language = (checkHindi.IsChecked == true))
            //{
            //    //checkHindi.Content.ToString();
            //    MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radMale.Content.ToString() + "," + radFemale.Content.ToString() + ", " + checkHindi.Content.ToString());
            //}
            //else
            //{
            //    //checkFrench.Content.ToString();
            //    MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radMale.Content.ToString() + "," + radFemale.Content.ToString() + ", " + checkFrench.Content.ToString());
            //}

            if(employee.Language = (checkEnglish.IsChecked == true))
            {
                MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radMale.Content.ToString() + "," + radFemale.Content.ToString() + "," + checkEnglish.Content.ToString()+"," + cblCountry.Text);

            }
            if(employee.Language = (checkHindi.IsChecked == true))
            {
                MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radMale.Content.ToString() + "," + radFemale.Content.ToString() + ", " + checkHindi.Content.ToString()+ "," + cblCountry.Text);

            }
            if(employee.Language = (checkFrench.IsChecked == true))
            {
                MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radMale.Content.ToString() + "," + radFemale.Content.ToString() + ", " + checkFrench.Content.ToString()+ "," + cblCountry.Text);

            }

            //if (employee.Gender = (Convert.ToBoolean(radMale.Content.ToString())) && (Convert.ToBoolean(radFemale.Content.ToString())))
            //{
            //    //radFemale.Content.ToString();
            //    MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radFemale.Content.ToString());

            //}
            //else
            //{
            //    //radMale.Content.ToString();
            //    MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radMale.Content.ToString());

            //}
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine("textBoxFirstName:{0} textBoxLastName:{1} textBoxEmail:{2} passwordBox1:{3} passwordBoxConfirm:{4} textBoxAddress:{5}", emp.FirstName, emp.LastName, emp.EmailId, emp.Password, emp.ConfirmPassword, emp.Address);

            //}
            //MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text);
            //MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text +","+ radMale.Content.ToString() +"," + radFemale.Content.ToString());
            //MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + "," + textBoxEmail.Text + "," + passwordBox1.Password + "," + passwordBoxConfirm.Password + "," + textBoxAddress.Text + "," + radMale.Content.ToString() + "," + radFemale.Content.ToString() + ", " + checkEnglish.Content.ToString() + ", " + checkHindi.Content.ToString() + ", " + checkFrench.Content.ToString());

            //Console.ReadKey();
            Console.ReadLine();
        }

    

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {

        }

        private void radMale_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void radFemale_Checked(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailId { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Address { get; set; }

        public bool Gender { get; set; }

        public bool Language { get; set; }

        public string Country { get; set; }
    }
}
