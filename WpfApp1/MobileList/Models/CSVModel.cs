using System.Windows;

namespace MobileList.Models
{
    public class CsvModel : DependencyObject
    {

        public string CSVPath
        {
            get { return (string)GetValue(CSVPathProperty); }
            set { SetValue(CSVPathProperty, value); }
        }

        public static readonly DependencyProperty CSVPathProperty =
            DependencyProperty.Register("CSVPath", typeof(string), typeof(CsvModel), new PropertyMetadata(""));
    }
}
