using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Example7.xaml
    /// </summary>
    public partial class Example7 : Window
    {
        //private ObservableCollection<Countries> countries;
        //public Countries Countries { get; set; }

        public Example7()
        {
            InitializeComponent();


            //Countries = new Countries() { id = 1, country = "India", state = "Gujarat" };

            //countries.Add(Countries);

            //MenList.Items.Add(new Countries() { Name = "Kalpit", ID = "456", Age = 35 });
            //MenList.Items.Add(new Countries() { Name = "Sachin", ID = "777", Age = 49 });
        }
}

    //public class Countries
    //{
    //    public int id { get; set; }
    //    public string country { get; set; }
    //    public string state { get; set; }

    //}
}
