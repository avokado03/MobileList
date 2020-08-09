using System;
using System.Windows;
using System.Windows.Input;

namespace MobileList.ViewModels.Commands
{
    public class WindowStateCommand: ICommand 
    {
        public WindowStateCommand(Window to)
        {
            _to = to;
        }

        private Window _to;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is Window && _to != null)
            {
                _to.Show();
                (parameter as Window).Close();
            }
        }
    }
}
