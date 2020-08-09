using MobileList.Models;
using System;
using System.Windows;
using MobileList.Models.Extentions;
using System.Diagnostics;
using System.Windows.Input;
using MobileList.ViewModels.Commands;
using Ookii.Dialogs.Wpf;

namespace MobileList.ViewModels
{
    public class DirectoriesViewModel : VMBase
    {
        public DirectoriesViewModel()
        {
            Model = new DirectoriesModel().GetAppDirectories();
            SetResultDirectoryCommand = new CommandBase(SetResultDir);
            SetPDFDirectoryCommand = new CommandBase(SetPDFDir);
            SetHTMLDirectoryCommand = new CommandBase(SetHTMLDir);
            SaveCommand = new CommandBase(Save);
            CleanCommand = new CommandBase(Clean);
        }

        public DirectoriesModel Model
        {
            get { return (DirectoriesModel)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }
        public static readonly DependencyProperty ModelProperty =
            DependencyProperty.Register("Model", typeof(DirectoriesModel), typeof(DirectoriesViewModel), new PropertyMetadata(null));

        #region CommandProps
        public ICommand SetResultDirectoryCommand
        {
            get { return (ICommand)GetValue(SetResultDirectoryCommandProperty); }
            set { SetValue(SetResultDirectoryCommandProperty, value); }
        }
        public static readonly DependencyProperty SetResultDirectoryCommandProperty =
            DependencyProperty.Register("SetResultDirectoryCommand", typeof(ICommand), typeof(DirectoriesViewModel), new PropertyMetadata(null));


        public ICommand SetPDFDirectoryCommand
        {
            get { return (ICommand)GetValue(SetPDFDirectoryCommandProperty); }
            set { SetValue(SetPDFDirectoryCommandProperty, value); }
        }
        public static readonly DependencyProperty SetPDFDirectoryCommandProperty =
            DependencyProperty.Register("SetPDFDirectoryCommand", typeof(ICommand), typeof(DirectoriesViewModel), new PropertyMetadata(null));


        public ICommand SetHTMLDirectoryCommand
        {
            get { return (ICommand)GetValue(SetHTMLDirectoryCommandProperty); }
            set { SetValue(SetHTMLDirectoryCommandProperty, value); }
        }
        public static readonly DependencyProperty SetHTMLDirectoryCommandProperty =
            DependencyProperty.Register("SetHTMLDirectoryCommand", typeof(ICommand), typeof(DirectoriesViewModel), new PropertyMetadata(null));


        public ICommand  SaveCommand
        {
            get { return (ICommand )GetValue(SaveCommandProperty); }
            set { SetValue(SaveCommandProperty, value); }
        }

        public static readonly DependencyProperty SaveCommandProperty =
            DependencyProperty.Register("SaveCommand", typeof(ICommand ), typeof(DirectoriesViewModel), new PropertyMetadata(null));



        public ICommand CleanCommand
        {
            get { return (ICommand)GetValue(CleanCommandProperty); }
            set { SetValue(CleanCommandProperty, value); }
        }
        public static readonly DependencyProperty CleanCommandProperty =
            DependencyProperty.Register("CleanCommand", typeof(ICommand), typeof(DirectoriesViewModel), new PropertyMetadata(null));

        #endregion

        #region Command actions
        //TODO: error handling
        private string SetDirectory()
        {
            var dialog = new VistaFolderBrowserDialog();
            var result = dialog.ShowDialog();
            if (result==false)
                throw new ArgumentException();
            return dialog.SelectedPath;
        }

        private void SetResultDir()
        {
            try
            {
                Model.ResultDir = SetDirectory();
                Error = string.Empty;
            }
            catch(ArgumentException ex)
            {
                //TODO: Error
            }
            catch (Exception)
            {
                //TODO: Error
            }
        }

        private void SetPDFDir()
        {
            try
            {
                Model.PDFDir = SetDirectory();
                Error = string.Empty;
            }
            catch (ArgumentException ex)
            {
                //TODO: Error
            }
            catch (Exception)
            {
                //TODO: Error
            }
        }

        private void SetHTMLDir()
        {
            try
            {
                Model.HTMLDir = SetDirectory();
                Error = string.Empty;
            }
            catch (ArgumentException ex)
            {
                //TODO: Error
            }
            catch (Exception)
            {
                //TODO: Error
            }
        }

        private void Save()
        {
            try
            {
                bool result = Model.SetAppDirectories();
                if (!result)
                    throw new ApplicationException();
                Process.Start(Process.GetCurrentProcess().MainModule.FileName);
                Application.Current.Shutdown();
            }
            catch(ApplicationException ex)
            {
                Error = "..";
            }
            catch(Exception)
            {
                Error = "..";
            }

        }

        public void Clean()
        {
            Model = Model.GetAppDirectories();
            Error = string.Empty;
        }

        #endregion
    }
}
