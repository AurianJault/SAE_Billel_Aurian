﻿#pragma checksum "..\..\..\UserControl4.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4739945B64171B414CE3F9369FB65320DF8C22EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Agent;
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


namespace Agent {
    
    
    /// <summary>
    /// UserControl4
    /// </summary>
    public partial class UserControl4 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\UserControl4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl Duellist;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UserControl4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Initiateur;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UserControl4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl Controlleur1;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\UserControl4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Controlleur;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UserControl4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl Sentinelle1;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UserControl4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sentinelle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Agent;V1.0.0.0;component/usercontrol4.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControl4.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Duellist = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 2:
            this.Initiateur = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\UserControl4.xaml"
            this.Initiateur.Click += new System.Windows.RoutedEventHandler(this.clickInitiateur);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Controlleur1 = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 4:
            this.Controlleur = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.Sentinelle1 = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 6:
            this.Sentinelle = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            
            #line 62 "..\..\..\UserControl4.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickNeon);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 69 "..\..\..\UserControl4.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickYoru);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 74 "..\..\..\UserControl4.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickJett);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 79 "..\..\..\UserControl4.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickPhoenix);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 85 "..\..\..\UserControl4.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickReyna);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

