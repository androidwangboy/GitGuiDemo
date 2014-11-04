using System.Collections.Generic;
using System.Windows.Input;

using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public interface IPlayerListModel : IViewModel
    {
        void Initialize();

        void RequestFrontPage();

        ICommand ClickSearchCommand { get; set; }
        ICommand ClickNextPage { get; set; }
        ICommand ClickFrontPage { get; set; }
        ICommand ClickStackPanelCommand { get; set; }
    }
}

