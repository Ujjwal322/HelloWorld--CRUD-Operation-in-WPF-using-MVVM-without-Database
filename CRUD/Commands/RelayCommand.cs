using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CRUD.Commands
{
    public class RelayCommand : ICommand
    {
        //public event EventHandler CanExecuteChanged;

        //private Action Dowork;

        //public RelayCommand(Action action)
        //{
        //    Dowork = action;
        //}

        //public bool CanExecute(object parameter)
        //{
        //    return true;
        //}

        //public void Execute(object parameter)
        //{
        //    Dowork();
        //}

        Action<object> action;
        Func<object, bool> canExecute;
        bool canExecuteCache;

        public RelayCommand(Action<object> action, Func<object, bool> canExecute, bool canExecuteCache)
        {
            this.canExecute = canExecute;
            this.action = action;
            canExecuteCache = canExecuteCache;
        }
        public bool CanExecute(object parameter)
        {
            if(canExecute == null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }

        

        public event EventHandler CanExecuteChanged
        {
            add
            {
                
                    CommandManager.RequerySuggested += value;
                
            }
            remove
            {
                
                    CommandManager.RequerySuggested -= value;
                
            }
        }

        public void Execute(object parameter)
        {
            action(parameter);

            
        }
    }
}
