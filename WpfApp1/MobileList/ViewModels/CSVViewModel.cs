using MobileList.Models;
using System;
using System.Windows.Input;
using System.Windows;
using Microsoft.Win32;
using MobileList.Views;
using MobileList.ViewModels.Commands;

namespace MobileList.ViewModels
{
    public class CSVViewModel : VMBase
    {

        public CSVViewModel()
        {
            Model = new CSVModel();
            OpenFileCommand = new CommandBase(OpenFile);
            CleanFilePathCommand = new CommandBase(CleanFilePath);
            SetDirectoriesCommand = new WindowStateCommand(new SetDirectories());
            base.SetPrevNext(null, new PDFTable());
        }

        public CSVModel Model
        {
            get { return (CSVModel)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }
        public static readonly DependencyProperty ModelProperty =
            DependencyProperty.Register("Model", typeof(CSVModel), typeof(CSVViewModel), new PropertyMetadata(null));

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



        public ICommand SetDirectoriesCommand
        {
            get { return (ICommand)GetValue(SetDirectoriesCommandProperty); }
            set { SetValue(SetDirectoriesCommandProperty, value); }
        }

        public static readonly DependencyProperty SetDirectoriesCommandProperty =
            DependencyProperty.Register("SetDirectoriesCommand", typeof(ICommand), typeof(CSVViewModel), new PropertyMetadata(null));



        #endregion

        #region Command actions
        private void OpenFile()
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    Filter = "CSV Files (*.csv)|*.csv"
                };
                if (!fileDialog.ShowDialog() == true)
                {
                    throw new ArgumentException("Проверьте расширение и целостность файла заказа");
                }
                Model.CSVPath = fileDialog.FileName;
                Error = string.Empty;
                Next = true;
            }
            catch (Exception)
            {
                Model.CSVPath = string.Empty;
                Error = "Файл не выбран";
                Next = false;
            }
        }

        private void CleanFilePath()
        {
            Model.CSVPath = string.Empty;
            Error = string.Empty;
            Next = false;
        }
        #endregion
    }
}
