using System;
using System.Windows;
using Augmentum.XGenos;
using Augmentum.XGenos.UI;
using Cafe.GitGuiPlatform.Exceptions;

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
