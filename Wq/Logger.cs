using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Wq
{
    public class Logger
    {
        // 表示这是一个逐字面字符串字面量（verbatim string literal）。它的作用是让字符串按字面意思解释，而不对其中的转义字符（如 \）进行特殊处理。
        public static void Log(string msg)
        {
            if (Const.OpenLog)
            {
                string filePath = Path.Combine(Const.PATH_APP, Const.FILE_LOG);
                File.AppendAllText(@filePath, "[WQ-LOG]" + msg + "\r\n");
            }
        }
        public static void Warn(string msg)
        {
            if (Const.OpenLog)
            {
                string filePath = Path.Combine(Const.PATH_APP, Const.FILE_LOG);
                File.AppendAllText(@filePath, "[WQ-WARN]" + msg + "\r\n");
            }
        }
        public static void Error(string msg)
        {
            if (Const.OpenLog)
            {
                string filePath = Path.Combine(Const.PATH_APP, Const.FILE_LOG);
                File.AppendAllText(@filePath, "[WQ-ERROR]" + msg + "\r\n");
            }
        }
    }
}
