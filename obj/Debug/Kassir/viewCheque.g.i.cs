﻿#pragma checksum "..\..\..\Kassir\viewCheque.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1ABC60C38F832AF16298DED4CF3B1399EB1C7B1EE6EC5D35FBC681C586AA5478"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Elena.Kassir;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Elena.Kassir {
    
    
    /// <summary>
    /// viewCheque
    /// </summary>
    public partial class viewCheque : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Kassir\viewCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uploadCheque;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Kassir\viewCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox allChequeComboBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Kassir\viewCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock userDataTextBlock;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Kassir\viewCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Kassir\viewCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock priceTextBlock;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Kassir\viewCheque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid chequeDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Elena;component/kassir/viewcheque.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Kassir\viewCheque.xaml"
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
            this.uploadCheque = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Kassir\viewCheque.xaml"
            this.uploadCheque.Click += new System.Windows.RoutedEventHandler(this.uploadCheque_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.allChequeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\Kassir\viewCheque.xaml"
            this.allChequeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.allChequeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.userDataTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.dateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.priceTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.chequeDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
