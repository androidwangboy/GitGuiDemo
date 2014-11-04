using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

using Augmentum.XGenos;
using Augmentum.XGenos.Commands;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class PlayerListModel : ViewModelBase, IPlayerListModel
    {
        #region Public Fields
        public int CurrentPageNumber { get; set; }

        public ICommand ClickSearchCommand { get; set; }
        public ICommand ClickNextPage { get; set; }
        public ICommand ClickFrontPage { get; set; }
        public ICommand ClickStackPanelCommand { get; set; }
        #endregion

        #region Default Constructor
        public PlayerListModel()
        {
            this.ClickNextPage = new DelegateCommand(RequestNextPage);
            this.ClickFrontPage = new DelegateCommand(RequestFrontPage);
        }
        #endregion

        #region Public Methods
        public void Initialize()
        {
        }


        public void ListAllPlayers()
        {
        }

        public void RequestNextPage()
        {
        }

        public void RequestFrontPage()
        {
        }
        #endregion
    }
}
