using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.ErrorMessages
{
    public class ParsingMessages
    {
        #region CSVToPDF

        public static string PDFNotFound(string issue, string pdfPath, string dir) =>
            $"Ошибка в позиции «{issue}». Не найден файл «{pdfPath}» в каталоге «{dir}». " +
            $"Проверьте имя файла и его наличие в директории.";

        #endregion

        #region PDFToHTML

        public static string TextColorNotFound(string issue, string pdfPath, string dir) =>
            $"Ошибка в позиции «{issue}». Файл «{pdfPath}» в каталоге «{dir}» содержит " +
            $"только цвет для резки. Проверьте макет.";

        public static string CutColorNotFound(string issue, string pdfPath, string dir) =>
            $"Ошибка в позиции «{issue}». Файл «{pdfPath}» в каталоге «{dir}» содержит " +
            $"только цвет для подписи. Проверьте макет.";

        public static string ColorsNotFound(string issue, string pdfPath, string dir) =>
            $"Ошибка в позиции «{issue}». Файл «{pdfPath}» в каталоге «{dir}» не содержит " +
            $"цветов для резки и подписи. Проверьте макет.";

        #endregion

        #region HTMLToResult
        #endregion
    }
}
