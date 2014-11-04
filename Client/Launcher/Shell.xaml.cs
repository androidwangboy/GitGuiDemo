//
// Copyright (c) 2013 Augmentum, Inc. All Rights Reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//
// Copyright (c) 2013 Augmentum, Inc. All Rights Reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.

using System;
using System.Configuration;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;

namespace Augmentum.Gaming.Table.Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Shell : Window
    {
        private const int WM_KEYCHAR = 0x102;
        private const int CTRL_F = 6;

        private readonly bool _isCursorEnabled = false;

        public Shell()
        {
            InitializeComponent();

            _isCursorEnabled = Boolean.Parse(ConfigurationManager.AppSettings["IsCursorEnabled"]);
            Mouse.OverrideCursor = _isCursorEnabled ? null : Cursors.None;

            ComponentDispatcher.ThreadPreprocessMessage += OnThreadPreprocessMessage;
        }

        private void OnThreadPreprocessMessage(ref MSG msg, ref bool handled)
        {
            if (msg.message == WM_KEYCHAR)
            {
                if (CTRL_F == msg.wParam.ToInt32())
                {
                    if (WindowStyle != WindowStyle.None || WindowState != WindowState.Maximized)
                    {
                        WindowStyle = WindowStyle.None;
                        WindowState = WindowState.Maximized;

                        // Hide cursor when cursor is not configured to show.
                        if (!_isCursorEnabled)
                        {
                            Mouse.OverrideCursor = Cursors.None;
                        }
                    }
                    else
                    {
                        WindowStyle = WindowStyle.ToolWindow;
                        WindowState = WindowState.Normal;

                        // Always need to show cursor in normal window mode.
                        Mouse.OverrideCursor = null;
                    }
                }
            }
        }

        #region Avoid Touch Move

        protected override void OnManipulationBoundaryFeedback(ManipulationBoundaryFeedbackEventArgs e) { }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs e) { }

        protected override void OnPreviewGiveFeedback(GiveFeedbackEventArgs e) { }

        #endregion
    }
}
