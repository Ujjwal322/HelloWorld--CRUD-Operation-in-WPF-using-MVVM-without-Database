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
    /// Interaction logic for BracketTab.xaml
    /// </summary>
    public partial class BracketTab : Window
    {
        private string value;

        public BracketTab()
        {
            InitializeComponent();
        }

        //private void BracketItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (value == "Program Det.")
        //        tblbutop.Visibility = Visibility.Hidden;
        //    else if (value == "Built-Up")
        //        tblbutop.Visibility = Visibility.Visible;
        //}

        //    private void Image_Loaded(object sender, RoutedEventArgs e)
        ////    {
        ////        // ... Create a new BitmapImage.
        ////        BitmapImage b = new BitmapImage();
        ////        b.BeginInit();
        ////        b.UriSource = new Uri("D:\\Ujjwal\\WPF\\HelloWorld\\CRUD\\Resources\\images\\NgdBeamBracketConnectGeo.png");
        ////        b.EndInit();

        ////        // ... Get Image reference from sender.
        ////        var image = sender as Image;
        ////        // ... Assign Source.
        ////        image.Source = b;
        ////    }
    }
}
