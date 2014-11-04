using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public interface IAreaSelectViewModel : IViewModel
    {
        void Initialize();

        ICommand SelectAreaCommand { get; set; }
    }
}
