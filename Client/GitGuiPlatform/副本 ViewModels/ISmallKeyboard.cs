
using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public interface ISmallKeyboard : IViewModel
    {
        void Initialize();

        ICommand ClickNumberCommand { get; set; }
    }
}
