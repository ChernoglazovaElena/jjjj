﻿#pragma checksum "..\..\..\DostavkaView\store.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "22A97D95B9CA8D58F85CE512BED2CB58036D81E5F88E4702EB6D5A5907D33673"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Elena.DostavkaView;
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


namespace Elena.DostavkaView {
    
    
    /// <summary>
    /// store
    /// </summary>
    public partial class store : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\DostavkaView\store.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid productsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\DostavkaView\store.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox houseNumber;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\DostavkaView\store.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox city;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\DostavkaView\store.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox street;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\DostavkaView\store.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\DostavkaView\store.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\DostavkaView\store.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update;
        
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
            System.Uri resourceLocater = new System.Uri("/Elena;component/dostavkaview/store.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DostavkaView\store.xaml"
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
            this.productsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\..\DostavkaView\store.xaml"
            this.productsDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.houseNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\DostavkaView\store.xaml"
            this.houseNumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.textBox2_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.city = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\DostavkaView\store.xaml"
            this.city.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.textBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.street = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\DostavkaView\store.xaml"
            this.street.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.textBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.save = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\DostavkaView\store.xaml"
            this.save.Click += new System.Windows.RoutedEventHandler(this.save_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.delete = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\DostavkaView\store.xaml"
            this.delete.Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.update = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\DostavkaView\store.xaml"
            this.update.Click += new System.Windows.RoutedEventHandler(this.update_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

