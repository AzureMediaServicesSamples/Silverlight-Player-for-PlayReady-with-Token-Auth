﻿#pragma checksum "C:\Users\christoc\Source\Silverlight Media Framework For Blogpost\microsoft-smf-src-2.2012.0605.0\Samples\Samples\PlayerControl\ExternalControls.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C797EF71A8D3A05D9D9E25BDF34B91AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.SilverlightMediaFramework.Core;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Microsoft.SilverlightMediaFramework.Samples.Samples.PlayerControl {
    
    
    public partial class ExternalControls : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox itemText;
        
        internal System.Windows.Controls.Button goButton;
        
        internal Microsoft.SilverlightMediaFramework.Core.SMFPlayer player;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Microsoft.SilverlightMediaFramework.Samples;component/Samples/PlayerControl/Exte" +
                        "rnalControls.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.itemText = ((System.Windows.Controls.TextBox)(this.FindName("itemText")));
            this.goButton = ((System.Windows.Controls.Button)(this.FindName("goButton")));
            this.player = ((Microsoft.SilverlightMediaFramework.Core.SMFPlayer)(this.FindName("player")));
        }
    }
}

