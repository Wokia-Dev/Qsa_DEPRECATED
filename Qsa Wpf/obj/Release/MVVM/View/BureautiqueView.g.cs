﻿#pragma checksum "..\..\..\..\MVVM\View\BureautiqueView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "606E8A8E7DFF131644FA4EA76EC6E3D6119BB42ECEAD148AE787B9BC63AE1591"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
    /// BureautiqueView
    /// </summary>
    public partial class BureautiqueView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\MVVM\View\BureautiqueView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox LibreOffice_checkBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\MVVM\View\BureautiqueView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Vlc_checkBox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\MVVM\View\BureautiqueView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox WinRar_CheckBox;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\MVVM\View\BureautiqueView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Spotify_CheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Qsa Wpf;component/mvvm/view/bureautiqueview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\BureautiqueView.xaml"
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
            
            #line 11 "..\..\..\..\MVVM\View\BureautiqueView.xaml"
            ((System.Windows.Controls.Grid)(target)).Initialized += new System.EventHandler(this.Grid_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LibreOffice_checkBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 34 "..\..\..\..\MVVM\View\BureautiqueView.xaml"
            this.LibreOffice_checkBox.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.LibreOffice_checkBox_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Vlc_checkBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 63 "..\..\..\..\MVVM\View\BureautiqueView.xaml"
            this.Vlc_checkBox.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Vlc_checkBox_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WinRar_CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 91 "..\..\..\..\MVVM\View\BureautiqueView.xaml"
            this.WinRar_CheckBox.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.WinRar_CheckBox_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Spotify_CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 120 "..\..\..\..\MVVM\View\BureautiqueView.xaml"
            this.Spotify_CheckBox.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Spotify_CheckBox_DataContextChanged_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

