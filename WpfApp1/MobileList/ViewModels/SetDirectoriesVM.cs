using MobileList.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

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
        #endregion

    }
}
