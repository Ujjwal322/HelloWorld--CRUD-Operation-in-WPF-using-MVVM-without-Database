using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for Example4.xaml
    /// </summary>
    public partial class Example4 : Window
    {
        public Example4()
        {
            InitializeComponent();
            McDataGrid.ItemsSource = LoadCollectionData();
        }


        //public enum Party
        //{
        //    Indepentent,
        //    Federalist,
        //    DemocratRepublican,
        //}
        public class Author
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public string BookTitle { get; set; }
            public bool IsMVP { get; set; }
        }

        private List<Author> LoadCollectionData()
        {
           
            List<Author> authors = new List<Author>();
            authors.Add(new Author()
            {
                ID = 101,
                Name = "Mahesh Chand",
                BookTitle = "Graphics Programming with GDI+",
                DOB = new DateTime(1975, 2, 23),
                IsMVP = false
            });

            authors.Add(new Author()
            {
                ID = 201,
                Name = "Mike Gold",
                BookTitle = "Programming C#",
                DOB = new DateTime(1982, 4, 12),
                IsMVP = true
            });

            authors.Add(new Author()
            {
                ID = 244,
                Name = "Mathew Cochran",
                BookTitle = "LINQ in Vista",
                DOB = new DateTime(1985, 9, 11),
                IsMVP = true
            });

            return authors;

            //private void RowColorButton_Click(object sender, RoutedEventArgs e)
            //{
            //    Author author = (Author)McDataGrid.SelectedItem;
            //    MessageBox.Show("Selected author: " + author.Name);
            //}

        }
        
        //public class Customer : INotifyPropertyChanged
        //{
        //    private string name;

        //    public string Name
        //    {
        //        get { return name; }
        //        set
        //        {
        //            name = value;
        //            RaiseProperChanged();
        //        }
        //    }

        //    private void RaiseProperChanged([CallerMemberName] string caller = "")
        //    {
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        //        }
        //    }

        //    private string title;

        //    public string Title
        //    {
        //        get { return title; }
        //        set
        //        {
        //            title = value;
        //            RaiseProperChanged();
        //        }
        //    }

        //    private bool wasReElected;

        //    public bool WasReElected
        //    {
        //        get { return wasReElected; }
        //        set
        //        {
        //            wasReElected = value;
        //            RaiseProperChanged();
        //        }
        //    }

        //    private Party affiliation;

        //    public Party Affiliation
        //    {
        //        get { return affiliation; }
        //        set
        //        {
        //            affiliation = value;
        //            RaiseProperChanged();
        //        }
        //    }

        //    public static ObservableCollection<Customer> GetCustomer()
        //    {
        //        var employees = new ObservableCollection<Customer>();

        //        employees.Add(new Customer()
        //        {
        //            Name = "Ali",
        //            Title = "Minister",
        //            WasReElected = true,
        //            Affiliation = Party.Indepentent
        //        });

        //        employees.Add(new Customer()
        //        {
        //            Name = "Ahmed",
        //            Title = "CM",
        //            WasReElected = false,
        //            Affiliation = Party.Federalist
        //        });

        //        employees.Add(new Customer()
        //        {
        //            Name = "Amjad",
        //            Title = "PM",
        //            WasReElected = true,
        //            Affiliation = Party.DemocratRepublican
        //        });

        //        employees.Add(new Customer()
        //        {
        //            Name = "Waqas",
        //            Title = "Minister",
        //            WasReElected = false,
        //            Affiliation = Party.Indepentent
        //        });

        //        employees.Add(new Customer()
        //        {
        //            Name = "Bilal",
        //            Title = "Minister",
        //            WasReElected = true,
        //            Affiliation = Party.Federalist
        //        });

        //        employees.Add(new Customer()
        //        {
        //            Name = "Waqar",
        //            Title = "Minister",
        //            WasReElected = false,
        //            Affiliation = Party.DemocratRepublican
        //        });

        //        return employees;
        //    }

        //    public event PropertyChangedEventHandler PropertyChanged;

        //}



    }
}
