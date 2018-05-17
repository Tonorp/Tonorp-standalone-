﻿#pragma checksum "..\..\..\Pages\NewEnrollment.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6D4F05229B9F894ADF8C794B410DBB35B290DD5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using TonorpStandAlone.Core.Logic;
using TonorpStandAloneWPF.Pages;


namespace TonorpStandAloneWPF.Pages {
    
    
    /// <summary>
    /// NewEnrollment
    /// </summary>
    public partial class NewEnrollment : TonorpStandAloneWPF.Pages.BasePage, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 92 "..\..\..\Pages\NewEnrollment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EnrLabel;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Pages\NewEnrollment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnShowTemplate;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Pages\NewEnrollment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel WrapPanel;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\Pages\NewEnrollment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl FingerThumbnail;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\Pages\NewEnrollment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ThumbnailLarge;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\Pages\NewEnrollment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\..\Pages\NewEnrollment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LblPercentage;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\..\Pages\NewEnrollment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDone;
        
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
            System.Uri resourceLocater = new System.Uri("/TonorpStandAloneWPF;component/pages/newenrollment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\NewEnrollment.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.EnrLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            
            #line 108 "..\..\..\Pages\NewEnrollment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeThumbnails_Clicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnShowTemplate = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\Pages\NewEnrollment.xaml"
            this.BtnShowTemplate.Click += new System.Windows.RoutedEventHandler(this.BtnShowTemplate_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WrapPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 5:
            this.FingerThumbnail = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 7:
            this.ThumbnailLarge = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 198 "..\..\..\Pages\NewEnrollment.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.CancelEnrollment_Clicked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LblPercentage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.BtnDone = ((System.Windows.Controls.Button)(target));
            
            #line 235 "..\..\..\Pages\NewEnrollment.xaml"
            this.BtnDone.Click += new System.Windows.RoutedEventHandler(this.EnrollmentDone_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 149 "..\..\..\Pages\NewEnrollment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnThumbnail_Clicked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
