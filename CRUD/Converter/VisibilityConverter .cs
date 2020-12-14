using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace CRUD.Converter
{
    public class VisibilityConverter : IValueConverter

    {

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)

        {

            try

            {

                if (Convert.ToBoolean(value.ToString())) return System.Windows.Visibility.Visible;

            }

            catch { }

            return System.Windows.Visibility.Collapsed;

        }



        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)

        {

            return null;

        }

        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    var val = value as bool?;
        //    return val.HasValue && val.Value ? Visibility.Visible : Visibility.Collapsed;
        //}

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    throw new NotImplementedException();
        //}


    }




}
