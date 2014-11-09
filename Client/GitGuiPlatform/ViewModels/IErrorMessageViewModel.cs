using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public interface IErrorMessageViewModel : IViewModel
    {
        ICommand OkCommand { get; set; }

        void Initialize(string title, string description, string errorCode);
    }
}
