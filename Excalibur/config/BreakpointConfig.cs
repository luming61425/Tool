﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码由 xsd 自动生成, Version=4.6.1055.0。
// 
namespace Excalibur {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://3gbywork.github.io/schema/BreakpointConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://3gbywork.github.io/schema/BreakpointConfig.xsd", IsNullable=false)]
    public partial class Breakpoints {
        
        private BreakpointsBreakpoint[] breakpointField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Breakpoint")]
        public BreakpointsBreakpoint[] Breakpoint {
            get {
                return this.breakpointField;
            }
            set {
                this.breakpointField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://3gbywork.github.io/schema/BreakpointConfig.xsd")]
    public partial class BreakpointsBreakpoint {
        
        private string filenameField;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
}
