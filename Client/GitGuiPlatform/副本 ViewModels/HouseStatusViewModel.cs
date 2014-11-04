using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class HouseStatusViewModel : ViewModelBase, IHouseStatusViewModel
    {
        #region Public Fields
        public ICommand SelectHouseStatusCommand { get; set; }
        #endregion

        #region Constructor
        public HouseStatusViewModel()
        {
        }
        #endregion

        #region Default Initialize
        public void Initialize()
        {
        }
        #endregion
    }
}
