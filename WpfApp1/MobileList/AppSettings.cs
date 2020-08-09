using System;
using System.Collections.Generic;
using System.Text;

namespace MobileList
{
    public static class AppSettings
    {
        public static string ResultPath => Environment.GetEnvironmentVariable("ResultPath");
        public static string PDFPath => Environment.GetEnvironmentVariable("PDFPath");
        public static string HTMLPath => Environment.GetEnvironmentVariable("HTMLPath");
    }
}
