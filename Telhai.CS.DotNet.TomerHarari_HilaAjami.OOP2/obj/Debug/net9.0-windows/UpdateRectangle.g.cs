﻿#pragma checksum "..\..\..\UpdateRectangle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9E67DD11532AEB3A612852CF8241F457D70E20E3"
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
using System.Windows.Forms.Integration;
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
using Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2;


namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2 {
    
    
    /// <summary>
    /// UpdateRectangle
    /// </summary>
    public partial class UpdateRectangle : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\UpdateRectangle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ColorLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UpdateRectangle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ColorComboBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UpdateRectangle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UpdateRectangle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox XTextBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\UpdateRectangle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UpdateRectangle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WidthTextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UpdateRectangle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HeightTextBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\UpdateRectangle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\UpdateRectangle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2;component/updaterectangle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UpdateRectangle.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ColorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ColorComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.XTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.YTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.WidthTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.HeightTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.UpdateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\UpdateRectangle.xaml"
            this.UpdateBtn.Click += new System.Windows.RoutedEventHandler(this.UpdateBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\UpdateRectangle.xaml"
            this.CancelBtn.Click += new System.Windows.RoutedEventHandler(this.CancelBtn_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

