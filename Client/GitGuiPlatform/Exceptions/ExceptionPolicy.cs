using System;

using Augmentum.XGenos.Environment.Extensions;
using Augmentum.XGenos.Exceptions;
using Augmentum.XGenos.Logging;

namespace Cafe.GitGuiPlatform.Exceptions
{
    [XGenosSuppressDependency("Augmentum.XGenos.Exceptions.DefaultExceptionPolicy")]
    public class ExceptionPolicy : IExceptionPolicy
    {
        #region Private Fields
        private readonly IExceptionHandler _exceptionHandler;
        #endregion

        #region Constructor
        public ExceptionPolicy(IExceptionHandler exceptionHandler)
        {
            Logger = NullLogger.Instance;

            _exceptionHandler = exceptionHandler;
        }
        #endregion

        #region Public Fields
        public ILogger Logger { get; set; }
        #endregion

        #region Public Methods
        public bool HandleException(object sender, Exception exception)
        {
            Logger.Error(exception, "An unexpected exception was caught.");

            _exceptionHandler.HandleException(sender, exception);
            return true;
        }
        #endregion
    }
}
