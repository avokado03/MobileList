using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MobileList.ViewModels
{
    public abstract class VMBase : DependencyObject
    {
        public VMBase()
        {
            Error = string.Empty;
            Next = false;
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

        // Using a DependencyProperty as the backing store for Next.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NextProperty =
            DependencyProperty.Register("Next", typeof(bool), typeof(VMBase), new PropertyMetadata(false));


    }
}
