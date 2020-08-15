using MobileList.ViewModels.Commands;
using System.Windows;
using System.Windows.Input;

namespace MobileList.ViewModels
{
    public abstract class VMBase : DependencyObject
    {
        //TODO: IoC
        public VMBase()
        {
            Error = string.Empty;
            Next = false;
        }

        public Window PrevousWindow { get; protected set; }
        public Window NextWindow { get; protected set; }

        protected void SetPrevNext(Window prev, Window next)
        {
            PrevousWindow = prev;
            NextWindow = next;
            GoToNextWindowCommand = new WindowStateCommand(NextWindow);
            GoToPrevousWindowCommand = new WindowStateCommand(PrevousWindow);
        }

        public string Error
        {
            get { return (string)GetValue(ErrorProperty); }
            set { SetValue(ErrorProperty, value); }
        }

        public static readonly DependencyProperty ErrorProperty =
            DependencyProperty.Register("Error", typeof(string), typeof(VMBase), new PropertyMetadata(""));

        public bool Next
        {
            get { return (bool)GetValue(NextProperty); }
            set { SetValue(NextProperty, value); }
        }

        public static readonly DependencyProperty NextProperty =
            DependencyProperty.Register("Next", typeof(bool), typeof(VMBase), new PropertyMetadata(false));


        public ICommand GoToPrevousWindowCommand
        {
            get { return (ICommand)GetValue(GoToPrevousWindowCommandProperty); }
            set { SetValue(GoToPrevousWindowCommandProperty, value); }
        }

        public static readonly DependencyProperty GoToPrevousWindowCommandProperty =
            DependencyProperty.Register("GoToPrevousWindowCommand", typeof(ICommand), typeof(VMBase), new PropertyMetadata(null));



        public ICommand GoToNextWindowCommand
        {
            get { return (ICommand)GetValue(GoToNextWindowCommandProperty); }
            set { SetValue(GoToNextWindowCommandProperty, value); }
        }

        public static readonly DependencyProperty GoToNextWindowCommandProperty =
            DependencyProperty.Register("GoToNextWindowCommand", typeof(ICommand), typeof(VMBase), new PropertyMetadata(null));

        protected abstract void CleanVM();
        protected virtual void CleanVM(string error)
        {
            CleanVM();
            Error = error;
        }
    }
}
