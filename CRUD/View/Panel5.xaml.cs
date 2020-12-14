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

namespace CRUD.View
{
    /// <summary>
    /// Interaction logic for Panel5.xaml
    /// </summary>
    public partial class Panel5 : Window
    {
        public Panel5()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee();

            employee.FirstName = textBoxFirstName.Text;
            employee.LastName = textBoxLastName.Text;
            employee.Address = textBoxAddress.Text;
            employee.Age = textBoxAge.Text;
            MessageBox.Show(textBoxFirstName.Text + "," + textBoxLastName.Text + ","+ textBoxAddress.Text + "," + textBoxAge.Text);

        }
    }

    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string Age { get; set; }
        public string Address { get; set; }

        
    }
}
