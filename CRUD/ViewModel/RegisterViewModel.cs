using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.ViewModel
{
    class RegisterViewModel : BindableBase
    {
        private bool _isButtonClicked;

        public bool IsButtonClicked
        {
            get { return _isButtonClicked; }
            set { SetProperty(ref _isButtonClicked, value); }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        public DelegateCommand<object> RegisterButtonClicked { get; set; }

        public RegisterViewModel()
        {
            RegisterButtonClicked = new DelegateCommand<object>(RegisterUser);
        }

        private void RegisterUser(object obj)
        {
            IsButtonClicked = true;
        }
    }
}
