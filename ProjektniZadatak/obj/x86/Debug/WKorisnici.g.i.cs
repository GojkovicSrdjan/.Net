﻿#pragma checksum "..\..\..\WKorisnici.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CA88BBC5BB1D56986469320079970D27"
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
    /// WKorisnici
    /// </summary>
    public partial class WKorisnici : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgKorisnici;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bIzmena;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bDodaj;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bIzbrisi;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lObavestenje;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPretraga;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bPretrazi;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bPrikaz;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbIme;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbPrezime;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\WKorisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbKorIme;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\WKorisnici.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ProjektniZadatak;component/wkorisnici.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WKorisnici.xaml"
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
            this.dgKorisnici = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.bIzmena = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\WKorisnici.xaml"
            this.bIzmena.Click += new System.Windows.RoutedEventHandler(this.bIzmena_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bDodaj = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\WKorisnici.xaml"
            this.bDodaj.Click += new System.Windows.RoutedEventHandler(this.bDodaj_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bIzbrisi = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\WKorisnici.xaml"
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
            
            #line 12 "..\..\..\WKorisnici.xaml"
            this.bPretrazi.Click += new System.Windows.RoutedEventHandler(this.bPretrazi_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.bPrikaz = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\WKorisnici.xaml"
            this.bPrikaz.Click += new System.Windows.RoutedEventHandler(this.bPrikaz_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rbIme = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.rbPrezime = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.rbKorIme = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            this.bPrikaziSve = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\WKorisnici.xaml"
            this.bPrikaziSve.Click += new System.Windows.RoutedEventHandler(this.bPrikaziSve_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

