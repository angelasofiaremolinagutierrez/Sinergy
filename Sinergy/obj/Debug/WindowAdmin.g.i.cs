﻿#pragma checksum "..\..\WindowAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F75D34F63DB24255FF31E4574A24F160D208194BD861679CC9D6CBBB122FF63"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Entorno_visual;
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


namespace Entorno_visual {
    
    
    /// <summary>
    /// WindowAdmin
    /// </summary>
    public partial class WindowAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Entorno_visual.WindowAdmin formAdmin;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonExit5;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_SignOut;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_CheckForms;
        
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
            System.Uri resourceLocater = new System.Uri("/Sinergy;component/windowadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowAdmin.xaml"
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
            this.formAdmin = ((Entorno_visual.WindowAdmin)(target));
            return;
            case 2:
            this.ButtonExit5 = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\WindowAdmin.xaml"
            this.ButtonExit5.Click += new System.Windows.RoutedEventHandler(this.ButtonExit5_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_SignOut = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\WindowAdmin.xaml"
            this.Button_SignOut.Click += new System.Windows.RoutedEventHandler(this.Button_SignOut_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_CheckForms = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\WindowAdmin.xaml"
            this.Button_CheckForms.Click += new System.Windows.RoutedEventHandler(this.Button_CheckForms_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

