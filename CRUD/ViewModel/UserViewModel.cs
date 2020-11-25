using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using CRUD.Commands;
using CRUD.Model;

namespace CRUD.ViewModel
{
    class UserViewModel :INotifyPropertyChanged
    {
        private User user;
        //private const string _asia = "Asia";
        //private const string _europe = "Europe";
        //private const string _northAmerica = "North America";
        public User User
        {
            get { return user; }
            set { user = value; NotifyPropertyChanged("User"); }
        }

        private ObservableCollection<User> users;

        public ObservableCollection<User> Users
        {
            get
            {
                return users;
            }

            set
            {
                users = value;
                NotifyPropertyChanged("Users");
            }
        }

        //public IList<User> usering = new List<User> {
        //        new User{Country="Marc",ID=1},
                          
        //};
        //public IList<User> Usering
        //{
        //    get { return usering; }
        //    set { usering = value; }
        //}
       // private ObservableCollection<User> Countries;
        //private IList<User> _UserList;

        //public UserViewModel()
        //{
        //    _UserList = new List<User> {
        //     new User{FirstName="Raj",LastName="Beniwal",EmailID="raj35@gmail.com",Address="Vadodara"}



        //    };
        //}

        //public IList<User> Users
        //{
        //    get { return _UserList; }
        //    set { _UserList = value; }
        //}

        //private ICommand mUpdater;

        private ICommand _SubmitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if(_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(SubmitExecute, CanSubmitExecute, false);
                }
                return _SubmitCommand;
            }
        }
        //public ObservableCollection<User> Countries { get; set; }
        public UserViewModel()
        {
            User = new User() { Language = "English" };
            //User = new User() { Language = "Hindi", Country = "USA", ID=2 };
            //User = new User() { Language = "Hindi" };
            Users = new ObservableCollection<User>();
           

            

            //this.Countries.Add(new User() {  Language = "Marathi" });
            //this.Countries.Add(new User() { Language = "Urdu" });
            //this.Countries.Add(new User() { Language = "Chinese" });

            //var countries = new User[]
            //{
            //    new User(1,"English"),
            //    new User(2,"Hindi")
            //};
            //this.Countries = new ObservableCollection<User>();
        }

        //private bool allSelected;

        //public bool AllSelected
        //{
        //    get
        //    {
        //        return this.allSelected;
        //    }
        //    set
        //    {
        //        allSelected = value;

        //        foreach (var country in this.Countries)
        //            country.IsSelected = value;
        //    }
        //}

       
        private void SubmitExecute(object parameter)
        {
            Users.Add(User);
        }

        private bool CanSubmitExecute(object parameter)
        {
            if (string.IsNullOrEmpty(User.FirstName) || string.IsNullOrEmpty(User.LastName) || string.IsNullOrEmpty(User.EmailID) || string.IsNullOrEmpty(User.Address))
            {
                return false;
            }
            else
            {
                return true;
            }
            //return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //private class Updater : ICommand
        //{
        //    public bool CanExecute(object parameter)
        //    {
        //        return true;
        //    }

        //    public event EventHandler CanExecuteChanged;

        //    public void Execute(object parameter)
        //    {

        //    }
        //}
    }
   
    public class GenderConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
    }
}
