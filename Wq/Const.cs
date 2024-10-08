using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wq
{
    public enum TYPE
    {
        MAP = 1, ITEM = 2, MONSTER = 3, MAGIC = 4, NPC = 5
    }
    internal class Const
    {
        public Const()
        {
        }
        public static string PATH_APP = AppDomain.CurrentDomain.BaseDirectory;
        public static string PATH_CONFIG = AppDomain.CurrentDomain.BaseDirectory;
        public static string FILE_LOG = "WQ_Log.txt";
        public static bool OpenLog = true;
    }
}
