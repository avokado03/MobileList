using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Helpers.ErrorMessages
{
    public class IOMessages
    {
        #region FileMsgs

        public const string BrokenFile = "Проверьте расширение и целостность файла заказа";
        public const string FileNotSelect = "Файл не выбран";
        public const string FileNotFound = "Файл не найден";

        #endregion

        #region DirectoryMsgs

        public static string BrokenDirectory (string dirName) => 
            $"Произошла ошибка при выборе директории {dirName}. Попробуйте снова";

        public static string DirectoryNotFound(string dirPath) =>
            $"Директория {dirPath} не найдена, попробуйте выбрать другую папку";

        public const string DirectorySelectFailed = "Не удалось сохранить новые пути директорий";

        #endregion
    }
}
