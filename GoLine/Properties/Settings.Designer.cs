﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoLine.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en-US")]
        public string UsingLang {
            get {
                return ((string)(this["UsingLang"]));
            }
            set {
                this["UsingLang"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Microsoft YaHei")]
        public string FontSetting {
            get {
                return ((string)(this["FontSetting"]));
            }
            set {
                this["FontSetting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("中文")]
        public string NextLang {
            get {
                return ((string)(this["NextLang"]));
            }
            set {
                this["NextLang"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en-US")]
        public string NewestLang {
            get {
                return ((string)(this["NewestLang"]));
            }
            set {
                this["NewestLang"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection StoredUser {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["StoredUser"]));
            }
            set {
                this["StoredUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SkyBlue")]
        public string ChessBrush {
            get {
                return ((string)(this["ChessBrush"]));
            }
            set {
                this["ChessBrush"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("pack://application:,,,/GoLine;component/Resources/Bg/bg.jpg")]
        public string BgPath {
            get {
                return ((string)(this["BgPath"]));
            }
            set {
                this["BgPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>AliceBlue</string>
  <string>SkyBlue</string>
  <string>CadetBlue</string>
  <string>Green</string>
  <string>DimGray</string>
  <string>Orange</string>
  <string>MediumSeaGreen</string>
  <string>Plum</string>
  <string>Tan</string>
  <string>Violet</string>
  <string>#3f51b5</string>
  <string>#f57f17</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AvaliableBrushes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AvaliableBrushes"]));
            }
            set {
                this["AvaliableBrushes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DimGray")]
        public string BoardLineBrush {
            get {
                return ((string)(this["BoardLineBrush"]));
            }
            set {
                this["BoardLineBrush"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoNoticeNewest {
            get {
                return ((bool)(this["AutoNoticeNewest"]));
            }
            set {
                this["AutoNoticeNewest"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableSounds {
            get {
                return ((bool)(this["EnableSounds"]));
            }
            set {
                this["EnableSounds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableMusic {
            get {
                return ((bool)(this["EnableMusic"]));
            }
            set {
                this["EnableMusic"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public double Volume {
            get {
                return ((double)(this["Volume"]));
            }
            set {
                this["Volume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DebugMode {
            get {
                return ((bool)(this["DebugMode"]));
            }
            set {
                this["DebugMode"] = value;
            }
        }
    }
}