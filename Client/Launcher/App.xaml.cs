//
// Copyright (c) 2013 Augmentum, Inc. All Rights Reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//

using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;

using Augmentum.CMS.ServiceProxy;

using Cafe.GitGuiPlatform;
using Cafe.GitGuiPlatform.Exceptions;
using Augmentum.Gaming.Launcher.Common;

using Augmentum.XGenos;
using Augmentum.XGenos.Environment;
using Augmentum.XGenos.Events;
using Augmentum.XGenos.Exceptions;
using Augmentum.XGenos.UI;

using Autofac;

namespace Augmentum.Gaming.Table.Launcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IExceptionPolicy _exceptionPolicy;

        public App()
        {
            DispatcherUnhandledException += OnDispatcherUnhandledException;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var assemblies = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "*.dll");

            var features = (from item in assemblies
                            where IsModule(item)
                            select Path.GetFileNameWithoutExtension(item)).ToArray();

            var bootstrapper = new Bootstrapper();

            bootstrapper.Initialize((builder) =>
            {
                builder.RegisterType<Shell>();
                builder.RegisterType<CustomizedInterceptor>().As<IServiceProxyInterceptor>();
            }, features, false);

            bootstrapper.Run(
                scope =>
                {
                    _exceptionPolicy = scope.Resolve<IExceptionPolicy>();

                    var shell = scope.Resolve<Shell>();

                    MainWindow = shell;
                    MainWindow.Show();

                    LoadCommonStyle();

                    return shell;
                },
                scope =>
                {
                    scope.Resolve<IEventAggregator>().GetEvent<TableStartupEvent>().Publish(null);
                });
        }

        private void LoadCommonStyle()
        {
            Resources.MergedDictionaries.Add(new ResourceDictionary
            {
                Source = new Uri("/GitGuiDemo;component/Styles/TouchScreenStyle.xaml", UriKind.Relative)
            });
            Resources.MergedDictionaries.Add(new ResourceDictionary
            {
                Source = new Uri("/Augmentum.CMS.Client.Controls;component/TouchScreen/Styles/TouchScreenStyle.xaml", UriKind.Relative)
            });
        }

        private bool IsModule(string item)
        {
            var extension = Path.GetExtension(item);
            var name = Path.GetFileNameWithoutExtension(item);

            return (extension.Equals(".dll", StringComparison.OrdinalIgnoreCase) && !name.StartsWith(typeof(Bootstrapper).Assembly.GetName().Name, StringComparison.OrdinalIgnoreCase) && !name.StartsWith("Autofac", StringComparison.OrdinalIgnoreCase));
        }

        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = _exceptionPolicy.HandleException(sender, e.Exception);
        }
    }
}
