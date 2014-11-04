using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public interface IHouseStatusViewModel : IViewModel
    {
        void Initialize();

        ICommand SelectHouseStatusCommand { get; set; }
    }
}
