using MobileList.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MobileList.Models
{
    public class CSVModel : DependencyObject, IErrorable
    {

        public string CSVPath
        {
            get { return (string)GetValue(CSVPathProperty); }
            set { SetValue(CSVPathProperty, value); }
        }

        public static readonly DependencyProperty CSVPathProperty =
            DependencyProperty.Register("CSVPath", typeof(string), typeof(CSVModel), new PropertyMetadata(""));



        public string Error
        {
            get { return (string)GetValue(ErrorProperty); }
            set { SetValue(ErrorProperty, value); }
        }

        public static readonly DependencyProperty ErrorProperty =
            DependencyProperty.Register("Error", typeof(string), typeof(CSVModel), new PropertyMetadata(""));



        //public CSVModel(string path)
        //{
        //    try
        //    {
        //        if (!path.EndsWith(".csv"))
        //            throw new ArgumentException("Файл не имеет расширения .csv");
        //        CSVPath = path;
        //        Error = string.Empty;
        //    }
        //    catch (Exception ex)
        //    {
        //        CSVPath = string.Empty;
        //        Error = ex.Message;
        //    }
        //}
    }
}
