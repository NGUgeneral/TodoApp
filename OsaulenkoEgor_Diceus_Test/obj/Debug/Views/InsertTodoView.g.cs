﻿#pragma checksum "..\..\..\Views\InsertTodoView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D07B3920A117A8DF3E40E2141356FB58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OsaulenkoEgor_Diceus_Test.Views;
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


namespace OsaulenkoEgor_Diceus_Test.Views {
    
    
    /// <summary>
    /// InsertTodoView
    /// </summary>
    public partial class InsertTodoView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\InsertTodoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OsaulenkoEgor_Diceus_Test.Views.InsertTodoView ucEditTodo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\InsertTodoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTitle;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\InsertTodoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbTitleWatermark;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\InsertTodoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMessage;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\InsertTodoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbMessageWatermark;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\InsertTodoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpExecute;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Views\InsertTodoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCancel;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Views\InsertTodoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSave;
        
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
            System.Uri resourceLocater = new System.Uri("/OsaulenkoEgor_Diceus_Test;component/views/inserttodoview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\InsertTodoView.xaml"
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
            this.ucEditTodo = ((OsaulenkoEgor_Diceus_Test.Views.InsertTodoView)(target));
            return;
            case 2:
            this.tbTitle = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\Views\InsertTodoView.xaml"
            this.tbTitle.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\Views\InsertTodoView.xaml"
            this.tbTitle.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbTitleWatermark = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tbMessage = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\Views\InsertTodoView.xaml"
            this.tbMessage.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\Views\InsertTodoView.xaml"
            this.tbMessage.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbMessageWatermark = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.dpExecute = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.lblCancel = ((System.Windows.Controls.Label)(target));
            
            #line 64 "..\..\..\Views\InsertTodoView.xaml"
            this.lblCancel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblCancel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblSave = ((System.Windows.Controls.Label)(target));
            
            #line 70 "..\..\..\Views\InsertTodoView.xaml"
            this.lblSave.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblSave_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

