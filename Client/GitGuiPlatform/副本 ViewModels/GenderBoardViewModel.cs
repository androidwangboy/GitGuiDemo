using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class GenderBoardViewModel : ViewModelBase, IGenderBoardViewModel
    {
        #region Public Fields
        public ICommand SelectGenderCommand { get; set; }
        #endregion

        #region Constructor
        public GenderBoardViewModel() 
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
