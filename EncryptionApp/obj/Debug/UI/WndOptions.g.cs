﻿#pragma checksum "..\..\..\UI\WndOptions.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0622FC5F10E78F6F7790DD2DE0D848F7D4415877D692448277158E5DBEE9B1E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EncryptionApp.UI;
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


namespace EncryptionApp.UI {
    
    
    /// <summary>
    /// WndOptions
    /// </summary>
    public partial class WndOptions : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\UI\WndOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TblCeusarShift;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UI\WndOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbCeusarShift;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UI\WndOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TblCharReplace;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\UI\WndOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbCharReplace;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UI\WndOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOk;
        
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
            System.Uri resourceLocater = new System.Uri("/EncryptionApp;component/ui/wndoptions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\WndOptions.xaml"
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
            
            #line 13 "..\..\..\UI\WndOptions.xaml"
            ((EncryptionApp.UI.WndOptions)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TblCeusarShift = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TbCeusarShift = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\UI\WndOptions.xaml"
            this.TbCeusarShift.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbCeusarShift_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TblCharReplace = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TbCharReplace = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\UI\WndOptions.xaml"
            this.TbCharReplace.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbCeusarShift_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnOk = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\UI\WndOptions.xaml"
            this.BtnOk.Click += new System.Windows.RoutedEventHandler(this.BtnOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

