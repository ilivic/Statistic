﻿#pragma checksum "..\..\..\PageApp\PageCorrHome.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C11F479304C560D9932F40BFD2170846303EFA9E9EBDA92F66DE2C7582912001"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Statistic.PageApp;
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


namespace Statistic.PageApp {
    
    
    /// <summary>
    /// PageCorrHome
    /// </summary>
    public partial class PageCorrHome : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\..\PageApp\PageCorrHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MIUser;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\PageApp\PageCorrHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MIHome;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\PageApp\PageCorrHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame LitleFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/Statistic;component/pageapp/pagecorrhome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageApp\PageCorrHome.xaml"
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
            this.MIUser = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 2:
            
            #line 83 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CLEventShowUser);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 84 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventBalance);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 85 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventGoLogin);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MIHome = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            
            #line 88 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventGoHomeMenu);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 91 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventAddCaunter);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 92 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventShowCounter);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 95 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventPushParam);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 96 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventShowHist);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 97 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventGetStatic);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 100 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventRecomendation);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 103 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventShowCreater);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 104 "..\..\..\PageApp\PageCorrHome.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventOpenGaid);
            
            #line default
            #line hidden
            return;
            case 15:
            this.LitleFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

