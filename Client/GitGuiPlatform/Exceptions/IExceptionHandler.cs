using System;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.Exceptions
{
    public interface IExceptionHandler : ISingletonDependency
    {
        void HandleException(object sender, Exception exception);
    }
}
