using System;
using System.Globalization;
using Augmentum.Gaming.Launcher.Common;
using Augmentum.XGenos.Commands;
using Augmentum.XGenos.Exceptions;
using Cafe.GitGuiPlatform.ViewModels;

namespace GitGuiDemo.Common
{
    public class DemoExceptionHandler : ExceptionHandlerBase
    {
        private readonly IErrorMessageViewModel _errorMessageViewModel;

        public DemoExceptionHandler(IErrorMessageViewModel errorMessageViewModel)
        {
            _errorMessageViewModel = errorMessageViewModel;
            _errorMessageViewModel.OkCommand = new DelegateCommand<object>(CloseApplication);
        }

        public override void HandleException(object sender, Exception exception)
        {
            var serviceException = exception as XGenosServiceException;
            if (serviceException != null)
            {
                switch (serviceException.ErrorCode)
                {
                    default:
                        _errorMessageViewModel.Initialize("Error", "SYSTERM_ERROR", serviceException.ErrorCode.ToString(CultureInfo.CurrentCulture));
                        break;
                }

                return;
            }

            base.HandleException(sender, exception);
        }
    }
}