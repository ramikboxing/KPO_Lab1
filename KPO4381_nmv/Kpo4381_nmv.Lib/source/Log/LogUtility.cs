using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Kpo4381_nmv.Utility
{
    public static class LogUtility
    {
        //Методы записи ошибок в текстовый файл
        public static void ErrorLog(string message)
        {
            // Расположение файла с сохр-ми ошибками
            string path = @"C:\VS\ErrorLog.txt"; 
                                    //Дата.Сегодня+ "-"+ сообщение+ новая строка
            File.AppendAllText(path, DateTime.Now + "-" + message + "\r\n");
        }
        public static void ErrorLog(Exception ex)
        {
            string path = @"C:\VS\ErrorLog1.txt";
            File.AppendAllText(path, DateTime.Now + "-" + ex.Message + "\r\n");
        }
    }
}
