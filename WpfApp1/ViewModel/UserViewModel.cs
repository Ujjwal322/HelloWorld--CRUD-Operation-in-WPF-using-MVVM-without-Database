using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private User user;
        //private const string _asia = "Asia";
        //private const string _europe = "Europe";
        //private const string _northAmerica = "North America";
        public User User
        {
            get { return user; }
            set { user = value;}
        }

        private ObservableCollection<string> _countries;
        public ObservableCollection<string> Countries
        {
            get { return _countries; ; }
            set
            {
                _countries = value;
                OnPropertyChange("Countries");
            }
        }

        private void OnPropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        private ICommand _MyCommand;
      

        public ICommand MyCommand {

            get
            {
                if (_MyCommand == null)
                {
                    _MyCommand = new RelayCommand(executemethod, canexecutemethod);
                }
                return _MyCommand;
            }



        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChange("Name");
            }
        }

        private bool canexecutemethod(object parameter)
        {
            return true;
        }
        private void executemethod(object parameter)
        {
            var values = (object[])parameter;
            string name = (string)values[0];
            bool check = (bool)values[1];
            if (check)
            {
                Countries.Add(name);
            }
            else
            {
                Countries.Remove(name);
            }

            Name = "";
            foreach (string item in Countries)
            {
                Name = Name + item;
            }
        }

        //    private void OnPropertyChange(string propertyname)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
