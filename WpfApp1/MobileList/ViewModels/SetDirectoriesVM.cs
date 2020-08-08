using MobileList.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MobileList.ViewModels
{
    public class SetDirectoriesVM : VMBase
    {
        public SetDirectoriesVM()
        {
            
        }

        public DirectoriesModel Model
        {
            get { return (DirectoriesModel)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }
        public static readonly DependencyProperty ModelProperty =
            DependencyProperty.Register("Model", typeof(DirectoriesModel), typeof(), new PropertyMetadata(null));

        #region CommandProps
            
        #endregion

        #region Command actions
        //TODO: error handling
        private void SetDirectory(string field)
        {
            try
            {
                var dialog = new CommonOpenFileDialog()
                {
                    IsFolderPicker = true
                };
                var result = dialog.ShowDialog();
                if (!(result == CommonFileDialogResult.Ok))
                    throw new ArgumentException();
                field = dialog.FileName;
             }
            catch(ArgumentException ex)
            {
                Error = "Беды с папками";
            }
            catch (Exception ex)
            {
                Error = "Беды с папками";
            }
        }
        #endregion
 
    }
}
