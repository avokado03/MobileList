using System.Windows;

namespace MobileList.Models
{
    public class CSVModel : DependencyObject
    {

        public string CSVPath
        {
            get { return (string)GetValue(CSVPathProperty); }
            set { SetValue(CSVPathProperty, value); }
        }

        public static readonly DependencyProperty CSVPathProperty =
            DependencyProperty.Register("CSVPath", typeof(string), typeof(CSVModel), new PropertyMetadata(""));
    }
}
