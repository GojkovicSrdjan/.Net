﻿#pragma checksum "..\..\..\WNastavnici.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "680E552BABB1125C323FCBB6C9353FA9"
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


namespace ProjektniZadatak {
    
    
    /// <summary>
    /// WNastavnici
    /// </summary>
    public partial class WNastavnici : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgNastavnici;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bPrikazIzmena;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bDodaj;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bIzbrisi;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lObavestenje;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPretraga;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bPretrazi;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbIme;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbPrezime;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbJMBG;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\WNastavnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bPrikaziSve;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjektniZadatak;component/wnastavnici.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WNastavnici.xaml"
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
            this.dgNastavnici = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.bPrikazIzmena = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\WNastavnici.xaml"
            this.bPrikazIzmena.Click += new System.Windows.RoutedEventHandler(this.bPrikazIzmena_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bDodaj = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\WNastavnici.xaml"
            this.bDodaj.Click += new System.Windows.RoutedEventHandler(this.bDodaj_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bIzbrisi = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\WNastavnici.xaml"
            this.bIzbrisi.Click += new System.Windows.RoutedEventHandler(this.bIzbrisi_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lObavestenje = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.tbPretraga = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.bPretrazi = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\WNastavnici.xaml"
            this.bPretrazi.Click += new System.Windows.RoutedEventHandler(this.bPretrazi_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rbIme = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.rbPrezime = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.rbJMBG = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.bPrikaziSve = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\WNastavnici.xaml"
            this.bPrikaziSve.Click += new System.Windows.RoutedEventHandler(this.bPrikaziSve_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

