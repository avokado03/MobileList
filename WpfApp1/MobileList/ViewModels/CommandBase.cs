using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MobileList.ViewModels
{
    public class CommandBase : ICommand
    {
        private Action _action;

        public CommandBase(Action action)
        {
            _action = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action?.Invoke();
        }
    }
}
