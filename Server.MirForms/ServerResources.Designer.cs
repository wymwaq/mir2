﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ServerResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ServerResources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Server.ServerResources", typeof(ServerResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Blocked IPs: {0} 的本地化字符串。
        /// </summary>
        internal static string BlockedIPsLabelFormat {
            get {
                return ResourceManager.GetString("BlockedIPsLabelFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Column {0} was not found. 的本地化字符串。
        /// </summary>
        internal static string ColumnNotFound {
            get {
                return ResourceManager.GetString("ColumnNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Connections: {0} 的本地化字符串。
        /// </summary>
        internal static string ConnectionsLabelFormat {
            get {
                return ResourceManager.GetString("ConnectionsLabelFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Monsters: {0} 的本地化字符串。
        /// </summary>
        internal static string MonsterLabelFormat {
            get {
                return ResourceManager.GetString("MonsterLabelFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Players: {0} 的本地化字符串。
        /// </summary>
        internal static string PlayersLabelFormat {
            get {
                return ResourceManager.GetString("PlayersLabelFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Total: {0}, Real: {1} 的本地化字符串。
        /// </summary>
        internal static string TotalLabelFormat {
            get {
                return ResourceManager.GetString("TotalLabelFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Uptime: {0}d:{1}h:{2}m:{3}s 的本地化字符串。
        /// </summary>
        internal static string UptimeFormat {
            get {
                return ResourceManager.GetString("UptimeFormat", resourceCulture);
            }
        }
    }
}
