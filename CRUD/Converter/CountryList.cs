using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CRUD.Converter
{
    //public class MyConverter : IMultiValueConverter
    //{
    //    public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        return values.Clone();
    //    }


    //    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        return null;
    //    }
    //}

    public class CountryList : List<string>
    {
        public CountryList()
        {
            this.Add("USA");
            this.Add("Canada");
            this.Add("India");
        }

    }
}
