//
// Copyright (c) 2013 Augmentum, Inc. All Rights Reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Cafe.GitGuiPlatform.Exceptions;
using Augmentum.XGenos;
using Augmentum.XGenos.UI;

namespace Augmentum.Gaming.Launcher.Common
{
    public abstract class ExceptionHandlerBase : IExceptionHandler
    {
        public IXGenosContainer Container { get; set; }
        public IZoneManager ZoneManager { get; set; }

        public virtual void HandleException(object sender, Exception exception) { }

        protected void AttachView(string zoneName, IViewModel viewModel)
        {
            var zone = ZoneManager.Zones[zoneName];

            if (null != zone && !zone.Contains(viewModel))
            {
                zone.Add(viewModel);
            }
        }

        protected void RemoveView(string zoneName, IViewModel viewModel)
        {
            var zone = ZoneManager.Zones[zoneName];

            if (null != zone && zone.Contains(viewModel))
            {
                zone.Remove(viewModel);
            }
        }

        protected void CloseApplication(object payload)
        {
            Application.Current.Shutdown();
        }
    }
}
