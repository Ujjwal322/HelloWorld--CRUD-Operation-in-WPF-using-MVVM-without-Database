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
    /// Interaction logic for Example5.xaml
    /// </summary>
    public partial class Example5 : Window
    {
        public Example5()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am the outer button");
        }

        private void outerEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = "This is Green Elipse";
        }

        private void InnButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am the inner button");
        }

        private void btnClickMe_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse moved by outer button");
        }

        private void Canvas_PrivewMouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse moved by Inner button");
        }
    }
}
