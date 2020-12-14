using CRUD.Model;
using CRUD.View;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
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
//using CRUD.ViewModel;

namespace CRUD
{
    /// <summary>
    /// Interaction logic for Example1.xaml
    /// </summary>
    public partial class Example1 : Window
    {
      
        public Example1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            View.Login login = new View.Login();
            login.Show();
            Close();
        }

        //private void rbnFemale_Checked(object sender, RoutedEventArgs e)
        //{
        //    rbnMale.IsEnabled = true;
        //    rbnMale.Visibility = Visibility.Visible;
        //}

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //User user = new User();
            //OpenFileDialog OpenFileObj = new OpenFileDialog();
            //OpenFileObj.ShowDialog();
            //txtimage.Text = OpenFileObj.FileName;
            //ImageSource image = new BitmapImage(new Uri(txtimage.Text));
            //img1.Source = image;
        }

        //private void button3_Click(object sender, RoutedEventArgs e)
        //{
        //    List<User> users = new List<User>();
        //    User user = new User();
        //    user.ImagePath = txtimage.Text;
        //    user.Image = File.ReadAllBytes(txtimage.Text);
        //    users.Add(user);

        //    //dataGrid1.ItemsSource = users.ToList();
        //}



        //private void rbnMale_Checked(object sender, RoutedEventArgs e)
        //{
        //    rbnFemale.IsEnabled = true;
        //    rbnFemale.Visibility = Visibility.Visible;
        //}

        //private void rbnFemale_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (rbnFemale.IsChecked == true)
        //    {
        //        txtHeight.Visibility = Visibility.Hidden;
        //        txtWeight.Visibility = Visibility.Hidden;
        //        cbxCricket.Visibility = Visibility.Visible;
        //    }
        //    else if(rbnMale.IsChecked == true)
        //    {
        //        txtHeight.Visibility = Visibility.Visible;
        //        txtWeight.Visibility = Visibility.Visible;
        //        cbxCricket.Visibility = Visibility.Hidden;
        //    }


        //}

        //private void rbnFemale_Checked(object sender, RoutedEventArgs e)
        //{
        //    rbnMale.Visibility = Visibility.Visible;
        //}



        //private void rbnMale_Checked(object sender, RoutedEventArgs e)
        //{
        //    if(rbnMale.IsChecked == true)
        //    {
        //        txtHeight.Visibility = Visibility.Visible;
        //        txtWeight.Visibility = Visibility.Visible;
        //    }
        //    else
        //    {
        //        cbxCricket.Visibility = Visibility.Hidden;
        //    }
        //}

        //private void rbnFemale_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (rbnFemale.IsChecked == true)
        //    {
        //        txtHeight.Visibility = Visibility.Hidden;
        //        txtWeight.Visibility = Visibility.Hidden;
        //    }
        //    else
        //    {
        //        cbxCricket.Visibility = Visibility.Visible;
        //    }
        //  }

        //private void cbxCricket_Checked(object sender, RoutedEventArgs e)
        //{
        //    txtWeight.Visibility = Visibility.Visible;
        //}

        //private void rbnFemale_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (rbnFemale.IsChecked == true)
        //    {
        //        txtHeight.Visibility = Visibility.Hidden;
        //        txtWeight.Visibility = Visibility.Hidden;
        //    }
        //    else
        //    {
        //        cbxCricket.Visibility = Visibility.Visible;
        //    }
        //}

        //private void RadioButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    //textBlockHeight.Visibility = Visibility.Collapsed;
        //    //textBlockWeight.Visibility = Visibility.Collapsed;

        //}
    }
}
