using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public interface IGenderBoardViewModel : IViewModel
    {
        void Initialize();

        ICommand SelectGenderCommand { get; set; }
    }
}
