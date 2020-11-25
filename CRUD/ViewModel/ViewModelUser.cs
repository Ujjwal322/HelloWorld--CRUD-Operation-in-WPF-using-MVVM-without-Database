using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using CRUD.Model;
using CRUD.Commands;

namespace CRUD.ViewModel
{   
    class ViewModelUser
    {
        //PersonnelBusinessObject personnel;
        //ObservableCollection<Employee> _Employee;
        //public RelayCommand CancelCommand { get; set; }
        //public RelayCommand SaveCommand { get; set; }
        //public RelayCommand AddUserCommand { get; set; }
        //public RelayCommand DeleteUserCommand { get; set; }

        //CancelCommand = new RelayCommand(DoCancel);
        //SaveCommand = new RelayCommand(DoSave);
        //AddUserCommand = new RelayCommand(AddUser);
        //DeleteUserCommand = new RelayCommand(DeleteUser);

        private IList<Employee> _Employee;
        public ViewModelUser()
        {
            //personnel = new PersonnelBusinessObject();
            _Employee = new List<Employee> { };

        }

        public IList<Employee> Employees
        {
            get { return _Employee; }
            set { _Employee = value; }
        }

        private ICommand mSubmit;
        public ICommand SubmitCommand
        {
            get
            {
                if(mSubmit == null)
                
                    mSubmit = new Submit();
                    return mSubmit;
                
            }
            set
            {
                mSubmit = value;
            }
        }


        private class Submit : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }
        }

        private Commands.RelayCommand saveCommand;

        public Commands.RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }

        //public ObservableCollection<Employee> Employees
        //{
        //    get
        //    {
        //        _Employee = new ObservableCollection<Employee>(personnel.GetEmployees());
        //        return _Employee;
        //    }
        //}

       
    }

   
}
