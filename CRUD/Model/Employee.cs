using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CRUD.Commands;


namespace CRUD.Model
{
    public class Employee : INotifyPropertyChanged
    {
        private int iD;

        private string firstName { get; set; }

        private string lastName { get; set; }

        private string emailId { get; set; }

        private string password { get; set; }

        private string confirmPassword { get; set; }

        private string address { get; set; }

        private string gender { get; set; }

        private string language { get; set; }

        //private string country { get; set; }

        //private bool _male;
        //private bool _female;
        //private bool _hindi;
        //private bool _english;
        //private bool _french;

        public Employee()
        {
            employeeService = new EmployeeService();
            CurrentEmployee = new Employee();
            //saveCommand = new RelayCommand(Save);
            
        }


        private Employee currentEmployee;

        public Employee CurrentEmployee
        {
             get { return currentEmployee; }
             set { currentEmployee = value; NotifyOfPropertyChange("currentEmployee"); }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; NotifyOfPropertyChange("Message"); }
        }
        


        private Commands.RelayCommand saveCommand;

        public Commands.RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }

        public void Save()
        {
            try
            {
                var IsSaved = employeeService.AddEmployee(CurrentEmployee);

                //if (IsSaved)
                //    Message = "Employee Saved";
                //else
                //    Message = "Save Operation Fail";
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int ID
        {
            get { return iD; }
            set
            {
                iD = value;
                NotifyOfPropertyChange("ID");

            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                NotifyOfPropertyChange("FirstName");
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                NotifyOfPropertyChange("LastName");
            }
        }

        public string EmailID
        {
            get { return emailId; }
            set
            {
                emailId = value;
                NotifyOfPropertyChange("EmailID");
            }
        }


        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyOfPropertyChange("Password");
            }
        }

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                NotifyOfPropertyChange("ConfirmPassword");
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                NotifyOfPropertyChange("Address");
            }
        }

        //public string Gender
        //{
        //    get { return gender; }
        //    set
        //    {
        //        address = value;
        //        NotifyOfPropertyChange("Gender");
        //    }
        //}

        //public string Language
        //{
        //    get { return language; }
        //    set
        //    {
        //        address = value;
        //        NotifyOfPropertyChange("Language");
        //    }
        //}



        //public string Gender
        //{
        //    get { return gender; }
        //    set
        //    {
        //        if (Male)
        //        {
        //            gender = "Male";
        //        }
        //        if (Female)
        //        {
        //            gender = "Female";
        //        }

        //        NotifyOfPropertyChange("Gender");
        //    }
        //}

        //public bool Male
        //{
        //    get { return _male; }
        //    set
        //    {
        //        _male = value;
        //        Gender = "Male";
        //        NotifyOfPropertyChange("Male");
        //    }
        //}

        //public bool Female
        //{
        //    get { return _female; }
        //    set
        //    {
        //        _female = value;
        //        Gender = "Female";
        //        NotifyOfPropertyChange("Female");
        //    }
        //}

        //public string Language
        //{
        //    get { return language; }
        //    set
        //    {
        //        language = string.Empty;
        //        string Comma = string.Empty;
        //        if (Hindi)
        //        {
        //            language = "Hindi";
        //        }
        //        if (English)
        //        {
        //            if (!string.IsNullOrEmpty(language))
        //            {
        //                Comma = ",";
        //            }
        //            language = language + Comma + "English";
        //        }
        //        if (French)
        //        {
        //            if (!string.IsNullOrEmpty(language))
        //            {
        //                Comma = ",";
        //            }
        //            language = language + Comma + "French";
        //        }
        //        NotifyOfPropertyChange("Language");
        //    }
        //}

        //public bool Hindi
        //{
        //    get { return _hindi; }
        //    set
        //    {
        //        _hindi = value;
        //        Language = "Hindi";
        //        NotifyOfPropertyChange("Hindi");
        //    }
        //}

        //public bool English
        //{
        //    get { return _english; }
        //    set
        //    {
        //        _english = value;
        //        Language = "English";
        //        NotifyOfPropertyChange("English");
        //    }
        //}

        //public bool French
        //{
        //    get { return _french; }
        //    set
        //    {
        //        _french = value;
        //        Language = "French";
        //        NotifyOfPropertyChange("French");
        //    }
        //}


        private void NotifyOfPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        EmployeeService employeeService;

    }
}
