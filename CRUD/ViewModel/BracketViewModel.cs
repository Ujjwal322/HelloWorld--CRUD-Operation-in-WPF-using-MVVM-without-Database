using CRUD.Converter;
using CRUD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static CRUD.Model.BracketEnum;


namespace CRUD.ViewModel
{
    public class BracketViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private BracketOptionEnum _bracket;

        //private BracketEnum bracket;

        //public BracketEnum BracketEnum
        //{
        //    get { return bracket; }
        //    set
        //    {
        //        bracket = value; NotifyPropertyChanged("bracket");
        //    }
        //}

        //private void NotifyPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    };
        //}
        //private TypeDescriptionProvider EnumIntegerConverterProvider;
        
        private Visibility _textBoxVisibility1;
        private Visibility _textBoxVisibility;

        public Visibility TextBoxVisibility
        {
            get { return _textBoxVisibility; }
            set
            {
                _textBoxVisibility = value;
                OnPropertyChanged();
            }
        }

        public Visibility TextBoxVisibility1
        {
            get { return _textBoxVisibility1; }
            set
            {
                _textBoxVisibility1 = value;
                OnPropertyChanged();
            }
        }


        public BracketOptionEnum BracketDetail
        {
            get { return _bracket; }

            set
            {
                _bracket = value;
               
                TextBoxVisibility = (BracketDetail == BracketOptionEnum.HotRolled) ? Visibility.Visible : Visibility.Collapsed;
                TextBoxVisibility1 = (BracketDetail == BracketOptionEnum.BuiltUpBeam) ? Visibility.Visible : Visibility.Collapsed;
                 OnPropertyChanged();
                //if (value =="Program Det.")
                //    TextBoxVisibility = Visibility.Hidden;
                //else
                //    TextBoxVisibility = Visibility.Visible;
            }
        }


        //private string _fonction;
        //public string Fonction
        //{
        //    get { return _fonction; }
        //    set
        //    {
        //        _fonction = value;
        //        OnPropertyChanged();
        //        if (value == "Program Det.")
        //            TextBoxVisibility = Visibility.Hidden;
        //        else
        //            TextBoxVisibility = Visibility.Visible;
        //    }
        //}










        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
