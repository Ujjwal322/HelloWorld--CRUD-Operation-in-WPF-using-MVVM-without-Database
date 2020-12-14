using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CRUD.Model
{
   public class User : INotifyPropertyChanged
    {
        private int _id;
       
      
       
        private string _language;
        private string _dob;
        private string _nationality;
       
        private bool _male = true;
        private bool _female;
        private bool _hindi;
        private bool _english;
        private bool _french;
        private Action<bool> onSelectionChanged;

        






        //public User(int id , string name)
        //{
        //    this._id = id;
        //    this._language = name;
        //}

        public User()
        {

        }

        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                //OnPropertyChanged();
            }
        }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(FirstName);
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(LastName);
            }
        }

        private string emailId;
        public string EmailID
        {
            get { return emailId; }
            set
            {
                emailId = value;
                OnPropertyChanged(EmailID);
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private string confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                OnPropertyChanged("ConfirmPassword");
            }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged(Address);
            }
        }

        private string _height;
        public string Height
        {
            get { return _height; }
            set
            {
                _height = value;
                OnPropertyChanged(Height);
            }
        }


        private string _weight;
        public string Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged(Weight);
            }
        }

        private string _country;

        public string Country
        {
            get { return _country; }
            set
            {
                _country = value;
                OnPropertyChanged(Country);
            }
        }
        private string _hobby;

        public string Hobby
        {
            get { return _hobby; }
            set
            {
                _hobby = value;
                OnPropertyChanged(Hobby);
            }
        }

        public string Language
        {
            get { return _language; }
            set
            {
                //_language = string.Empty;
                //string Comma = string.Empty;
                //if (Hindi)
                //{
                //    _language = "Hindi";
                //}
                //if (English)
                //{
                //    if (!string.IsNullOrEmpty(_language))
                //    {
                //        Comma = ",";
                //    }
                //    _language = _language + Comma + "English";
                //}
                //if (French)
                //{
                //    if (!string.IsNullOrEmpty(_language))
                //    {
                //        Comma = ",";
                //    }
                //    _language = _language + Comma + "French";
                //}
                //_english = false;
                //_hindi = false;
                //_french = false;
                _language = value;
                OnPropertyChanged("Language");
            }
        }

        //public string DOB
        //{
        //    get { return _dob; }
        //    set
        //    {
        //        _dob = Convert.ToDateTime(value).ToString("MM/dd/yyyy");
        //        NotifyOfPropertyChange("DOB");
        //    }
        //}

        //public string Nationality
        //{
        //    get { return _nationality; }
        //    set
        //    {
        //        _nationality = value;
        //        NotifyOfPropertyChange("Nationality");
        //    }
        //}
        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; 
                NotifyPropertyChanged();
                this.onSelectionChanged(value);
            }
        }

        public string DOB
        {
            get { return _dob; }
            set
            {
                _dob = Convert.ToDateTime(value).ToString("MM/dd/yyyy");
                OnPropertyChanged("DOB");
            }
        }

        private byte[] _img;
        public byte[] Image {

            get { return _img; }

            set
            {
                _img = value;
                OnPropertyChanged("Image");
            }
        
        }

        private string _ImagePath;
        public string ImagePath {

            get { return _ImagePath; }
        
            set
            {
                _ImagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }

        public bool Male 
        {
            get { return this._male; }
            set
            {
                this._male = value;
                //Gender = "Male";
                //this.SetOtherRadioToFalse();
                this.OnPropertyChanged("RaidoIsCheck");
                OnPropertyChanged("TextValue");
            }
        }

        //private void SetOtherRadioToFalse()
        //{
        //    this.Male = true;
        //}

        public bool Female
        {
            get { return this._female; }
            set
            {
                this._female = value;
                //Gender = "Female";
                this.OnPropertyChanged("Male");
                OnPropertyChanged("TextValue");
            }
        }

        private string _gender = "Male";
        public string Gender
        {
            get { return this._gender; }
            set
            {
                //if (Male)
                //{
                //    _gender = "Male";
                //}
                //if (Female)
                //{
                //    _gender = "Female";
                //}
                this._gender = value;
              this.OnPropertyChanged("Male");
            }
        }

        private string _gender1 = "Female";
        public string Gender1
        {
            get { return this._gender1; }
            set
            {
                //if (Male)
                //{
                //    _gender = "Male";
                //}
                //if (Female)
                //{
                //    _gender = "Female";
                //}
                this._gender1 = value;
                this.OnPropertyChanged("Female");
            }
        }

        public string TextValue
        {
            get
            {
                string selected = this.Male ? this.Gender : this.Gender1;
                return string.Format("{0}", selected);
            }
        }

        public bool Hindi
        {
            get { return _hindi; }
            set
            {
                _hindi = value;
                Language = "Hindi";
                OnPropertyChanged("Hindi");
                TriggerAll();
            }
        }

        private void TriggerAll()
        {
            if (_hindi && _english )
                _french = true;
            else if (!_hindi && !_english )
                _french = false;
            else
                _french = true;
        }

        public bool English
        {
            get { return _english; }
            set
            {
                _english = value;
                Language = "English";
                OnPropertyChanged("English");
                TriggerAll();
            }
        }

        public bool French
        {
            get { return _french; }
            set
            {
                _french = value;
                Language = "French";
               OnPropertyChanged("French");

                if(value == true)
                {
                    _hindi = true;
                    _english = true;
                    OnPropertyChanged("English");
                    OnPropertyChanged("Hindi");
                }
                else if (value == false)
                {
                    _hindi = false;
                    _english = false;
                    OnPropertyChanged("English");
                    OnPropertyChanged("Hindi");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(v));
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
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
}
