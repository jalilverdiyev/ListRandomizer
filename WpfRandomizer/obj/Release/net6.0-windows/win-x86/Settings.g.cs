#pragma checksum "..\..\..\..\Settings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "175E39A5A70969F60A2A70A4B5074FD901C985B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfRandomizer;


namespace WpfRandomizer {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton EnterRadio;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CommaRadio;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton NumberRadio;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox NumberedCheckBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfRandomizer;component/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Settings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EnterRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 39 "..\..\..\..\Settings.xaml"
            this.EnterRadio.Checked += new System.Windows.RoutedEventHandler(this.Option_OnChecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CommaRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 40 "..\..\..\..\Settings.xaml"
            this.CommaRadio.Checked += new System.Windows.RoutedEventHandler(this.Option_OnChecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NumberRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 41 "..\..\..\..\Settings.xaml"
            this.NumberRadio.Checked += new System.Windows.RoutedEventHandler(this.Option_OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NumberedCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\Settings.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

