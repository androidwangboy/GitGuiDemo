using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class SmallKeyboardViewModel : ViewModelBase, ISmallKeyboard
    {
        #region Public Fields
        public ICommand ClickNumberCommand { get; set; }
        #endregion

        #region Constructor
        public SmallKeyboardViewModel()
        {
        }
        #endregion

        #region Public Methods
        public void Initialize()
        {
        }
        #endregion
    }
}
