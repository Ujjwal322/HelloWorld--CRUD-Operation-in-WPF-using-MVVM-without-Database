﻿using System;
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
    /// Interaction logic for Panel2.xaml
    /// </summary>
    public partial class Panel2 : Window
    {
        public Panel2()
        {
            InitializeComponent();
        }

        private void Click_Me(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string str = btn.Content.ToString() + " button clicked";
            MessageBox.Show(str);
        }
    }
}
