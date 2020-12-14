using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CRUD.Converter
{
    //class HobbyList
    //{
    //}

    //public class HobbyList : List<string>
    //{
    //    public HobbyList()
    //    {
    //        this.Add("Cricket");
    //        this.Add("Reading");
    //        this.Add("Traveling");
    //    }

    //}


    public class MyConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return values.Clone();
        }


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }


}
