﻿#pragma checksum "..\..\..\Views\CommitHistoryView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5725E03E1E1B99FA04AD3D7AF8BFB3E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Cafe.GitGuiPlatform.ViewModels;
using Cafe.GitGuiPlatform.Views;
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
using System.Windows.Interactivity;
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


namespace Cafe.GitGuiPlatform.Views {
    
    
    /// <summary>
    /// CommitHistoryView
    /// </summary>
    public partial class CommitHistoryView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\Views\CommitHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Cafe.GitGuiPlatform.Views.CommitHistoryView m_Self;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\CommitHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image m_GoToSearch;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Views\CommitHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl m_CommitListItemControl;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Views\CommitHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image m_PreviousPage;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\Views\CommitHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image m_NextPage;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\Views\CommitHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock m_CurrentPage;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\Views\CommitHistoryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock m_TotalPage;
        
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
            System.Uri resourceLocater = new System.Uri("/GitGuiPlatform;component/views/commithistoryview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CommitHistoryView.xaml"
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
            this.m_Self = ((Cafe.GitGuiPlatform.Views.CommitHistoryView)(target));
            return;
            case 2:
            this.m_GoToSearch = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.m_CommitListItemControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 4:
            this.m_PreviousPage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.m_NextPage = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.m_CurrentPage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.m_TotalPage = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
