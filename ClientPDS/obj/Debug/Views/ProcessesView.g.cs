﻿#pragma checksum "..\..\..\Views\ProcessesView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EEFCA9C5752F485744DBC9C944109FA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientPDS;
using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace ClientPDS {
    
    
    /// <summary>
    /// ProcessesView
    /// </summary>
    public partial class ProcessesView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Views\ProcessesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Apps;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Views\ProcessesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ToggleSwitch EnableHotkeySwitch;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\ProcessesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ToggleSwitch altSwitch;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\ProcessesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ToggleSwitch ctrlSwitch;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Views\ProcessesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ToggleSwitch shiftSwitch;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Views\ProcessesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ServerIpLbl;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Views\ProcessesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServerIpTxt;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Views\ProcessesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConnectionBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ClientPDS;component/views/processesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ProcessesView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Apps = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.EnableHotkeySwitch = ((MahApps.Metro.Controls.ToggleSwitch)(target));
            return;
            case 3:
            this.altSwitch = ((MahApps.Metro.Controls.ToggleSwitch)(target));
            return;
            case 4:
            this.ctrlSwitch = ((MahApps.Metro.Controls.ToggleSwitch)(target));
            return;
            case 5:
            this.shiftSwitch = ((MahApps.Metro.Controls.ToggleSwitch)(target));
            return;
            case 6:
            this.ServerIpLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.ServerIpTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ConnectionBtn = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\Views\ProcessesView.xaml"
            this.ConnectionBtn.Click += new System.Windows.RoutedEventHandler(this.ConnectionBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

