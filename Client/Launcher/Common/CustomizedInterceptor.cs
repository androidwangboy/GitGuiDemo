//
// Copyright (c) 2013 Augmentum, Inc. All Rights Reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

using Augmentum.CMS.Client.Controls.CommonControl;
using Augmentum.CMS.ClientFramework.I18N;
using Augmentum.CMS.ServiceProxy;

using Augmentum.XGenos;
using Castle.Core.Interceptor;

namespace Augmentum.Gaming.Launcher.Common
{
    public class CustomizedInterceptor : ServiceProxyInterceptor
    {
        private readonly IXGenosContainer _container;

        private static object syncRoot = new Object();

        public CustomizedInterceptor(IXGenosContainer container)
        {
            _container = container;
        }

        public override void Intercept(IInvocation invocation)
        {
            var dispatcher = Application.Current.Dispatcher;
            var isInDispatcherThread = (dispatcher.Thread.ManagedThreadId == Thread.CurrentThread.ManagedThreadId);

            var completed = false;
            Exception exception = null;

            Action action = () =>
            {
                try
                {
                    base.Intercept(invocation);
                }
                catch (Exception ex)
                {
                    exception = ex;
                }
                finally
                {
                    completed = true;
                }

            };

            if (isInDispatcherThread)
            {
                var messageKey = string.Format(CultureInfo.CurrentCulture, "Waiting_{0}_{1}", invocation.Method.DeclaringType.Name.Remove(0, 1), invocation.Method.Name);
                var message = GetMessage(messageKey);

                if (string.IsNullOrWhiteSpace(message))
                {
                    message = GetMessage("Waiting_Message");
                }

                LoadingControlManager.Instance.IsBusy = true;
                LoadingControlManager.Instance.Message = message;

                Task.Factory.StartNew(action);

                while (!completed)
                {
                    dispatcher.Invoke(DispatcherPriority.Background, new Action(() => { }));
                }

                LoadingControlManager.Instance.IsBusy = false;
                LoadingControlManager.Instance.Message = string.Empty;

                if (null != exception)
                {
                    throw exception;
                }
            }
            else
            {
                action.Invoke();

                if (null != exception)
                {
                    throw exception;
                }
            }
        }

        public string GetMessage(string key)
        {
            if (LanguageManager.Current.Lang.ContainsKey(key))
            {
                return LanguageManager.Current.Lang[key];
            }

            return null;
        }
    }
}
