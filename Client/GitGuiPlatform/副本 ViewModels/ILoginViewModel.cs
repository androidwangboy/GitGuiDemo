using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public interface ILoginViewModel : IViewModel
    {
        void Initialize();

        string Username { get; set; }
        string Password { get; set; }

        void UpdateUserCode(string status);

        ICommand ClickCommand { get; set; }
    }
}