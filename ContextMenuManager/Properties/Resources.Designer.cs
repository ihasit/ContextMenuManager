﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContextMenuManager.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ContextMenuManager.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap About {
            get {
                object obj = ResourceManager.GetObject("About", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Add {
            get {
                object obj = ResourceManager.GetObject("Add", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap AddExisting {
            get {
                object obj = ResourceManager.GetObject("AddExisting", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap AddSeparator {
            get {
                object obj = ResourceManager.GetObject("AddSeparator", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 ;此文件为ContextMenuManager程序的显示文本字典
        ///;如果你想要帮助作者为此程序添加其他语言字典, 可以修改此文本并保存在.\config\languages文件夹内, 
        ///;比如美国英语字典保存为en-US.ini, 并给[General]\Language赋值 en-US English
        ///;可以在Github或Gitee上Fork该项目并提交申请给我，或者直接发送文件到邮箱1617859183@qq.com
        ///;翻译说明：暂时不翻译的值保留为空即可，字典内赋值换行请使用\n进行转义
        ///
        ///[General]
        ///Language = zh-CN 简体中文
        ///Translator = 蓝点lilac
        ///AppName = Windows右键管理
        ///
        ///[ToolBar]
        ///Home = 主页
        ///Type = 文件类型
        ///Rule = 其他规则
        ///Refresh = 刷新
        ///About = 关于
        ///
        ///[SideBar]
        ///File = 文件
        ///Folder = 文件夹
        ///Directory = 目录
        ///Background = 目录背景
        ///Desktop = 桌面背景
        ///Drive = 磁盘 [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string AppLanguageDic {
            get {
                return ResourceManager.GetString("AppLanguageDic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap CustomType {
            get {
                object obj = ResourceManager.GetObject("CustomType", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Delete {
            get {
                object obj = ResourceManager.GetObject("Delete", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Donate {
            get {
                object obj = ResourceManager.GetObject("Donate", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&apos;1.0&apos; encoding=&apos;utf-8&apos; ?&gt;
        ///&lt;!--此文件为常用右键菜单字典,
        ///Tip属性为鼠标悬浮在开关上时的提示信息，从每个Item节点开始, 子元素Value表示该项的注册表键值，目前仅支持REG_SZ、REG_DWORD、REG_EXPAND_SZ的键值类型，
        ///子元素SubKey的所有子元素是该项的子项，项名即为元素名; 每一Item项和SubKey的所有子元素的属性Default为该注册表项默认值，不放在Value\REG_SZ元素里面是为了防止与可能存在的键名为Default的键产生冲突--&gt;
        ///&lt;Data&gt;
        ///  &lt;File&gt;
        ///    &lt;Shell&gt;
        ///      &lt;Item KeyName=&apos;CopyAsPath&apos; Tip=&apos;系统原生菜单项需按住Shift显示,&amp;#x000A;此项可以直接显示&apos;&gt;
        ///        &lt;Value&gt;
        ///          &lt;REG_SZ MUIVerb=&apos;复制文件路径&apos; Icon=&apos;imageres.dll,-5302&apos;/&gt;
        ///        &lt;/Value&gt;
        ///        &lt;SubKey&gt;
        ///           [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string EnhanceMenusDic {
            get {
                return ResourceManager.GetString("EnhanceMenusDic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ;&lt;说明&gt;:
        ///;由于ShellEx类型右键菜单的菜单名称和图标无法直接获取，只能通过制作字典给用户更直观的体验
        ///;此文件为依赖&lt;GUID&gt;的ShellEx类型右键菜单项目的名称和图标字典
        ///;&lt;GUID&gt;可通过右键程序内ShellEx项目&quot;复制guid&quot;获取
        ///;不带括号的&lt;GUID&gt;为字典索引
        ///
        ///;&lt;Text&gt;:
        ///;Text为菜单项目名称
        ///;可以赋值为引用资源文件字符串资源的本地化字符串,
        ///;格式为&quot;@&lt;资源文件路径&gt;,-&lt;字符串资源索引&gt;&quot;,如赋值为&quot;@shell32.dll,-3576&quot;
        ///;也可以赋值为直接显示名称,如赋值为&quot;使用XXX打开&quot;
        ///
        ///;&lt;Icon&gt;:
        ///;Icon为菜单项目图标资源位置
        ///;格式为&quot;&lt;资源文件路径&gt;,&lt;图标序号&gt;&quot;，如赋值为&quot;C:Windows\System32\imageres.dll,203&quot;
        ///;&lt;图标序号&gt;为负数则为图标资源索引,为非负数则为图标资源顺序序号
        ///;Icon为空时默认提取文件第一个图标，没有图标则使用dll文件默认图标
        ///
        ///;&lt;资源文件路径&gt;:
        ///;&lt;Text&gt;和&lt;Icon&gt;中的&lt;资源文件路径&gt;一般使用相对路径
        ///;如果资源文件所在 [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string GuidInfosDic {
            get {
                return ResourceManager.GetString("GuidInfosDic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Home {
            get {
                object obj = ResourceManager.GetObject("Home", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap MicrosoftStore {
            get {
                object obj = ResourceManager.GetObject("MicrosoftStore", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap NewItem {
            get {
                object obj = ResourceManager.GetObject("NewItem", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Open {
            get {
                object obj = ResourceManager.GetObject("Open", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Refresh {
            get {
                object obj = ResourceManager.GetObject("Refresh", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap SeparatorItem {
            get {
                object obj = ResourceManager.GetObject("SeparatorItem", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Setting {
            get {
                object obj = ResourceManager.GetObject("Setting", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Star {
            get {
                object obj = ResourceManager.GetObject("Star", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap SubItems {
            get {
                object obj = ResourceManager.GetObject("SubItems", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;!--每个程序为一个Group，Text为Group项显示文本，Guid用于判断用户是否安装此程序并决定是否显示该Group，不设置Guid则为常驻菜单，RegPath为程序相关注册表主路径;
        ///其相关菜单项目设置作为一个Item子元素，Item的Text为该Item项显示文本，Tip属性为鼠标悬浮在开关上时的提示信息，需要重启资源管理器生效则添加属性RestartExplorer;
        ///Item的子元素Rule为相关注册表内容，RegPath省略则默认为Group主路径，以\开头则为Group主路径的子项路径；ValueName为相关键名，On为启用键值，Off为禁用键值；
        ///每个Item可能受多个注册表Rule影响，按照顺序进行键值判定；程序优先判定为On，即只要所有Rule不匹配Off键值就判定为On，键值类型不符时也判定为On;
        ///ValueKind为键值类型，默认键值类型ValueKind为REG_DWORD，为默认值时可省略，目前仅支持REG_SZ、REG_DWORD、REG_EXPAND_SZ的键值类型--&gt;
        ///&lt; [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string ThirdRulesDic {
            get {
                return ResourceManager.GetString("ThirdRulesDic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap TurnOff {
            get {
                object obj = ResourceManager.GetObject("TurnOff", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap TurnOn {
            get {
                object obj = ResourceManager.GetObject("TurnOn", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Type {
            get {
                object obj = ResourceManager.GetObject("Type", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Types {
            get {
                object obj = ResourceManager.GetObject("Types", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Up {
            get {
                object obj = ResourceManager.GetObject("Up", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
