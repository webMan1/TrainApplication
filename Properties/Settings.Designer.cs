﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Firenze S. M. Novella")]
        public string Firenze {
            get {
                return ((string)(this["Firenze"]));
            }
            set {
                this["Firenze"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Milano Centrale")]
        public string Milano {
            get {
                return ((string)(this["Milano"]));
            }
            set {
                this["Milano"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Torino Porta Susa")]
        public string Torino {
            get {
                return ((string)(this["Torino"]));
            }
            set {
                this["Torino"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Milano Centrale</string>
  <string>Modena</string>
  <string>Firenze</string>
  <string>Bologna</string>
  <string>Torino</string>
  <string>Padova</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection hubs {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["hubs"]));
            }
            set {
                this["hubs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int minLayover {
            get {
                return ((int)(this["minLayover"]));
            }
            set {
                this["minLayover"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("360")]
        public int preferredStart {
            get {
                return ((int)(this["preferredStart"]));
            }
            set {
                this["preferredStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("550")]
        public int preferredFinish {
            get {
                return ((int)(this["preferredFinish"]));
            }
            set {
                this["preferredFinish"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int timeCostRatio {
            get {
                return ((int)(this["timeCostRatio"]));
            }
            set {
                this["timeCostRatio"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("660")]
        public int preferredHubTime {
            get {
                return ((int)(this["preferredHubTime"]));
            }
            set {
                this["preferredHubTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Bologna Centrale")]
        public string Bologna {
            get {
                return ((string)(this["Bologna"]));
            }
            set {
                this["Bologna"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Montevarchi-Terranuova")]
        public string Montevarchi {
            get {
                return ((string)(this["Montevarchi"]));
            }
            set {
                this["Montevarchi"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Genova Piazza Principe")]
        public string Genova {
            get {
                return ((string)(this["Genova"]));
            }
            set {
                this["Genova"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Cities {
            get {
                return ((string)(this["Cities"]));
            }
            set {
                this["Cities"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1230")]
        public int preferredSleepoverTime {
            get {
                return ((int)(this["preferredSleepoverTime"]));
            }
            set {
                this["preferredSleepoverTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\\\Users\\\\SEC2016583\\\\Desktop\\\\Recommendations by Kekoolani.xlsx")]
        public string inputFile {
            get {
                return ((string)(this["inputFile"]));
            }
            set {
                this["inputFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("output.txt")]
        public string outputFile {
            get {
                return ((string)(this["outputFile"]));
            }
            set {
                this["outputFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Master Travel Plans")]
        public string sheetName {
            get {
                return ((string)(this["sheetName"]));
            }
            set {
                this["sheetName"] = value;
            }
        }
    }
}
