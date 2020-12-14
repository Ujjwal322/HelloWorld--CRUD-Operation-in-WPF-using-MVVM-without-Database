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
using System.Windows.Threading;

namespace CRUD.View
{
    /// <summary>
    /// Interaction logic for Panel3.xaml
    /// </summary>
    public partial class Panel3 : Window
    {
        public Panel3()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal,
                                                        delegate
                                                        {
                                                            int newval = 0;

                                                            if (Counter == int.MaxValue)
                                                            {
                                                                newval = 0;
                                                            }
                                                            else
                                                            {
                                                                newval = Counter + 1;
                                                            }

                                                            SetValue(counterdependencyProperty, newval);
                                                        }, Dispatcher);
        }

        //private int DependencyProperty;  // to access variable it is wrapped inside a property.

        //public int MyProperty
        //{
        //    get { return DependencyProperty; }
        //    set { DependencyProperty = value; }
        //}



        public int Counter
        {
            get { return (int)GetValue(counterdependencyProperty); }
            set { SetValue(counterdependencyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Counter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty counterdependencyProperty =
            DependencyProperty.Register("Counter", typeof(int), typeof(Panel3), new PropertyMetadata(0));



    }
}
