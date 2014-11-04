using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class LoginViewModel : ViewModelBase, ILoginViewModel
    {
        #region Public Properties

        public string Value { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        
        public ICommand ClickCommand { get; set; }

        #endregion

        #region Constructor
        public LoginViewModel()
        {
        }
        #endregion

        #region Public Methods
        public void Initialize()
        {
            Value = "Login";
        }

        public void UpdateUserCode(string status)
        {
            Value = status;
        }
        #endregion
    }
}
