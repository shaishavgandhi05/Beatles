﻿#pragma checksum "C:\Users\Amit\Documents\Visual Studio 2013\Projects\Beatles1\Beatles1\AddPost.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5B13F0F0597378D3B353B12E1C532EAC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace Beatles1 {
    
    
    public partial class AddPost : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox TopicNameBox;
        
        internal System.Windows.Controls.Button PostSubmitButton;
        
        internal System.Windows.Controls.ProgressBar ThisIsOutProgressBar;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Beatles1;component/AddPost.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TopicNameBox = ((System.Windows.Controls.TextBox)(this.FindName("TopicNameBox")));
            this.PostSubmitButton = ((System.Windows.Controls.Button)(this.FindName("PostSubmitButton")));
            this.ThisIsOutProgressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("ThisIsOutProgressBar")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
        }
    }
}

