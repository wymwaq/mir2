using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
//using System.Windows.Forms;

namespace Wq
{
    public class LanMgr
    {
        private static Dictionary<string, string[]> id_V2K_map;
        private static Dictionary<uint, string[]> id_V2K_item;
        private static Dictionary<uint, string[]> id_V2K_monster;
        private static Dictionary<string, string[]> id_V2K_magic;
        private static Dictionary<string, string[]> id_V2K_npc;

        private static LanMgr _ins = null;
        private static readonly object _insLock = new object();

        public static bool openload = false; // 将英文转为中文
        public static bool opensave = false;

        public static LanMgr Ins
        {
            get
            {
                if (_ins == null) // 双重检查锁定模式
                {
                    lock (_insLock)
                    {
                        if (_ins == null)
                        {
                            _ins = new LanMgr();
                            _ins.Init(); // 在第一次实例化时调用 Init
                        }
                    }
                }
                return _ins;
            }
        }

        private void Init()
        {
            // 配置语言包地址
            id_V2K_map = loadCsv("lan/map/csv_V2K.csv", s => s);
            id_V2K_item = loadCsv("lan/item/csv_V2K.csv", uint.Parse);
            id_V2K_monster = loadCsv("lan/monster/csv_V2K.csv", uint.Parse);
            id_V2K_magic = loadCsv("lan/magic/csv_V2K.csv", s => s);
            id_V2K_npc = loadCsv("lan/npc/csv_V2K.csv", s => s);
        }

        // 初始化，从CSV文件中加载数据
        private Dictionary<TKey, string[]> loadCsv<TKey>(string relativeFilePath, Func<string, TKey> keyParser)
        {
            // 获取当前项目的根目录
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // 构建CSV文件的完整路径
            string filePath = Path.Combine(baseDirectory, relativeFilePath);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("CSV 文件未找到: " + filePath);
            }

            Dictionary<TKey, string[]> temp = new Dictionary<TKey, string[]>();
            // 读取CSV文件内容
            var lines = File.ReadAllLines(filePath);

            // 遍历每一行（跳过第一行头部）
            for (int i = 1; i < lines.Length; i++)
            {
                var columns = lines[i].Split(',');

                // 检查是否有足够的列，确保ID, EN, CN存在
                if (columns.Length >= 3)
                {
                    string idString = columns[0].Trim();
                    TKey key;

                    try
                    {
                        // 使用提供的keyParser将字符串解析为指定的键类型
                        key = keyParser(idString);
                    }
                    catch
                    {
                        continue; // 如果解析失败，跳过这一行
                    }

                    string enValue = columns[1].Trim();
                    string cnValue = columns[2].Trim();
                    temp[key] = new string[] { enValue, cnValue };
                }
            }
            return temp;
        }

        public string GetValue<T>(T id, TYPE type, int languageIndex, Dictionary<T, string[]> dic, string language)
        {
            if (dic == null)
            {
                Logger.Error($"id = {id} , type = {type} 无效的类型");
                return "无效的类型";
            }
            if (dic.TryGetValue(id, out string[] values))
            {
                if (values[languageIndex] == "" || values[languageIndex].IndexOf("WQ_TODO") > -1)
                {
                    return values[0];
                }
                return values[languageIndex]; // 返回指定语言值
            }
            else
            {
                Logger.Error($"id = {id} , type = {type} 未找到的{language}值");
                return values[0];
            }
        }

        public string ToEN(uint id, TYPE type)
        {
            var dic = type switch
            {
                TYPE.ITEM => id_V2K_item,
                TYPE.MONSTER => id_V2K_monster,
                _ => null
            };
            return GetValue(id, type, 0, dic, "EN");
        }

        public string ToEN(string id, TYPE type)
        {
            var dic = type switch
            {
                TYPE.MAP => id_V2K_map,
                TYPE.MAGIC => id_V2K_magic,
                TYPE.NPC => id_V2K_npc,
                _ => null
            };
            return GetValue(id, type, 0, dic, "EN");
        }

        public string ToCN(uint id, TYPE type)
        {
            var dic = type switch
            {
                TYPE.ITEM => id_V2K_item,
                TYPE.MONSTER => id_V2K_monster,
                _ => null
            };
            return GetValue(id, type, 1, dic, "CN");
        }

        public string ToCN(string id, TYPE type)
        {
            var dic = type switch
            {
                TYPE.MAP => id_V2K_map,
                TYPE.MAGIC => id_V2K_magic,
                TYPE.NPC => id_V2K_npc,
                _ => null
            };
            return GetValue(id, type, 1, dic, "CN");
        }

    }
}
