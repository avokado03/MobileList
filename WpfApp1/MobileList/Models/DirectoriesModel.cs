using System.Windows;

namespace MobileList.Models
{
    public class DirectoriesModel : DependencyObject
    {

        public string ResultDir
        {
            get { return (string)GetValue(ResultDirProperty); }
            set { SetValue(ResultDirProperty, value); }
        }
        public static readonly DependencyProperty ResultDirProperty =
            DependencyProperty.Register("ResultDir", typeof(string), typeof(DirectoriesModel), new PropertyMetadata(""));



        public string PDFDir
        {
            get { return (string)GetValue(PDFDirProperty); }
            set { SetValue(PDFDirProperty, value); }
        }

        public static readonly DependencyProperty PDFDirProperty =
            DependencyProperty.Register("PDFDir", typeof(string), typeof(DirectoriesModel), new PropertyMetadata(""));



        public string HTMLDir
        {
            get { return (string)GetValue(HTMLDirProperty); }
            set { SetValue(HTMLDirProperty, value); }
        }

        public static readonly DependencyProperty HTMLDirProperty =
            DependencyProperty.Register("HTMLDir", typeof(string), typeof(DirectoriesModel), new PropertyMetadata(""));

    }
}
