using MobileList.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows;
using Microsoft.Win32;
using GalaSoft.MvvmLight.Command;

namespace MobileList.ViewModels
{
    public class CSVViewModel : DependencyObject
    {

        public CSVViewModel()
        {
            Model = new CSVModel();
            IsError = false;
            OpenFileCommand = new CommandBase(OpenFile);
            CleanFilePathCommand = new CommandBase(CleanFilePath);
        }

        public CSVModel Model
        {
            get { return (CSVModel)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }
        public static readonly DependencyProperty ModelProperty =
            DependencyProperty.Register("Model", typeof(CSVModel), typeof(CSVViewModel), new PropertyMetadata(null));



        public bool IsError
        {
            get { return (bool)GetValue(IsErrorProperty); }
            set { SetValue(IsErrorProperty, value); }
        }

        public static readonly DependencyProperty IsErrorProperty =
            DependencyProperty.Register("IsError", typeof(bool), typeof(CSVViewModel), new PropertyMetadata(false));



        #region Command props
        public ICommand OpenFileCommand
        {
            get { return (ICommand)GetValue(OpenFileCommandProperty); }
            set { SetValue(OpenFileCommandProperty, value); }
        }
        public static readonly DependencyProperty OpenFileCommandProperty =
            DependencyProperty.Register("OpenFileCommand", typeof(ICommand), typeof(CSVViewModel), new PropertyMetadata(null));

        public ICommand CleanFilePathCommand
        {
            get { return (ICommand)GetValue(CleanFilePathCommandProperty); }
            set { SetValue(CleanFilePathCommandProperty, value); }
        }

        public static readonly DependencyProperty CleanFilePathCommandProperty =
            DependencyProperty.Register("CleanFilePathCommand", typeof(ICommand), typeof(CSVViewModel), new PropertyMetadata(null));

        #endregion

        #region Command actions
        private void OpenFile()
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "CSV Files (*.csv)|*.csv";
                if (!fileDialog.ShowDialog() == true)
                {
                    throw new ArgumentException("Проверьте расширение и целостность файла заказа");
                }
                Model.CSVPath = fileDialog.FileName;
                IsError = false;
            }
            catch (Exception)
            {
                Model.CSVPath = string.Empty;
                Model.Error = "Файл не выбран";
                IsError = true;
            }
        }

        private void CleanFilePath()
        {
            Model.CSVPath = string.Empty;
            Model.Error = string.Empty;
            IsError = false;
        }
        #endregion
    }
}
