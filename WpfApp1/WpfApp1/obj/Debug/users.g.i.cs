﻿#pragma checksum "..\..\users.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07B866F1700F08C20B1048365A0D15B97D9779532553241582E14ADB0CEF68E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// users
    /// </summary>
    public partial class users : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextSearch;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DiscountSortText;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DiscountSort;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CostSort;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewServices;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountServices;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/users.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\users.xaml"
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
            this.TextSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\users.xaml"
            this.TextSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DiscountSortText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.DiscountSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\users.xaml"
            this.DiscountSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DiscountSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CostSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\users.xaml"
            this.CostSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DiscountSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListViewServices = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.CountServices = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

