﻿#pragma checksum "..\..\..\..\..\PresentationTier\Animes\DeadmanWonderland\DeadmanWonderlandStreamer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC21A4FF913F66A6E10FF2FC18CCDBF5E3B0CE7A36E4ED3C7177FEE86CC23D4E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SakuraDesktop.PresentationTier.Animes.DeadmanWonderland;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace SakuraDesktop.PresentationTier.Animes.DeadmanWonderland {
    
    
    /// <summary>
    /// DeadmanWonderlandStreamer
    /// </summary>
    public partial class DeadmanWonderlandStreamer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\PresentationTier\Animes\DeadmanWonderland\DeadmanWonderlandStreamer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.Integration.WindowsFormsHost hostE1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\PresentationTier\Animes\DeadmanWonderland\DeadmanWonderlandStreamer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Title;
        
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
            System.Uri resourceLocater = new System.Uri("/SakuraDesktop;component/presentationtier/animes/deadmanwonderland/deadmanwonderl" +
                    "andstreamer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\PresentationTier\Animes\DeadmanWonderland\DeadmanWonderlandStreamer.xaml"
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
            
            #line 7 "..\..\..\..\..\PresentationTier\Animes\DeadmanWonderland\DeadmanWonderlandStreamer.xaml"
            ((SakuraDesktop.PresentationTier.Animes.DeadmanWonderland.DeadmanWonderlandStreamer)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\..\..\..\PresentationTier\Animes\DeadmanWonderland\DeadmanWonderlandStreamer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonExit);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 16 "..\..\..\..\..\PresentationTier\Animes\DeadmanWonderland\DeadmanWonderlandStreamer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonMinimize);
            
            #line default
            #line hidden
            return;
            case 4:
            this.hostE1 = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 5:
            this.Title = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

