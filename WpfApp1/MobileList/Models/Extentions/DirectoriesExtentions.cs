using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MobileList.Models.Extentions
{
    public static class DirectoriesExtentions
    {
        public static DirectoriesModel GetAppDirectories(this DirectoriesModel model)
        {
            model.ResultDir = AppSettings.ResultPath;
            model.PDFDir = AppSettings.PDFPath;
            model.HTMLDir = AppSettings.HTMLPath;
            return model;
        }

        public static bool SetAppDirectories(this DirectoriesModel model)
        {
            try
            {
                Environment.SetEnvironmentVariable("ResultPath", model.ResultDir);
                Environment.SetEnvironmentVariable("PDFPath", model.PDFDir);
                Environment.SetEnvironmentVariable("HTMLPath", model.HTMLDir);
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
