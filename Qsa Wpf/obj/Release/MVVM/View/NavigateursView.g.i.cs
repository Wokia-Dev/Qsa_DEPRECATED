﻿#pragma checksum "..\..\..\..\MVVM\View\NavigateursView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9889D56BD7BB03A46111EF6AAEB37B253F043A85315E9105EEA66C5F38537965"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Qsa_Wpf.MVVM.View;
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


namespace Qsa_Wpf.MVVM.View {
    
    
    /// <summary>
    /// NavigateursView
    /// </summary>
    public partial class NavigateursView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\MVVM\View\NavigateursView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Chrome_CheckBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\MVVM\View\NavigateursView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FireFox_CheckBox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\MVVM\View\NavigateursView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Brave_CheckBox;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\MVVM\View\NavigateursView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Opera_CheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Qsa Wpf;component/mvvm/view/navigateursview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\NavigateursView.xaml"
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
            
            #line 10 "..\..\..\..\MVVM\View\NavigateursView.xaml"
            ((System.Windows.Controls.Grid)(target)).Initialized += new System.EventHandler(this.Grid_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Chrome_CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 35 "..\..\..\..\MVVM\View\NavigateursView.xaml"
            this.Chrome_CheckBox.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Chrome_CheckBox_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FireFox_CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 63 "..\..\..\..\MVVM\View\NavigateursView.xaml"
            this.FireFox_CheckBox.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.FireFox_CheckBox_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Brave_CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 91 "..\..\..\..\MVVM\View\NavigateursView.xaml"
            this.Brave_CheckBox.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Brave_CheckBox_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Opera_CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 119 "..\..\..\..\MVVM\View\NavigateursView.xaml"
            this.Opera_CheckBox.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Opera_CheckBox_DataContextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

