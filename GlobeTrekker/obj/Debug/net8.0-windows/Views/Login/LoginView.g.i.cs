// Updated by XamlIntelliSenseFileGenerator 2024. 12. 09. 22:02:31
#pragma checksum "..\..\..\..\..\Views\Login\LoginView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3D3C07942BD1F32CF77E0450B282E66D53A61C10"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GlobeTrekker.Controls;
using GlobeTrekker.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace GlobeTrekker.Views.Login
{


    /// <summary>
    /// LoginView
    /// </summary>
    public partial class LoginView : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 62 "..\..\..\..\..\Views\Login\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;

#line default
#line hidden


#line 96 "..\..\..\..\..\Views\Login\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;

#line default
#line hidden


#line 153 "..\..\..\..\..\Views\Login\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUser;

#line default
#line hidden


#line 182 "..\..\..\..\..\Views\Login\LoginView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GlobeTrekker;V1.0.0.0;component/views/login/loginview.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\..\Views\Login\LoginView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler)
        {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 17 "..\..\..\..\..\Views\Login\LoginView.xaml"
                    ((KretaBasicSchoolSystem.Desktop.Views.Login.LoginView)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);

#line default
#line hidden
                    return;
                case 2:
                    this.btnMinimize = ((System.Windows.Controls.Button)(target));

#line 69 "..\..\..\..\..\Views\Login\LoginView.xaml"
                    this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.btnClose = ((System.Windows.Controls.Button)(target));

#line 105 "..\..\..\..\..\Views\Login\LoginView.xaml"
                    this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.txtUser = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.btnLogin = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

