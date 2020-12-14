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
    /// Interaction logic for Example6.xaml
    /// </summary>
    public partial class Example6 : Window
    {
        public Example6()
        {
            InitializeComponent();

            MenList.Items.Add(new Person() { Name = "Ravi", ID = "123", Age = 20 });
            MenList.Items.Add(new Person() { Name = "Kalpit", ID = "456", Age = 35 });
            MenList.Items.Add(new Person() { Name = "Sachin", ID = "777", Age = 49 });
        }

    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
