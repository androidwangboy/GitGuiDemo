using System;
using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class CommitHistoryViewModel : ViewModelBase, ICommitHistoryViewModel
    {
        #region Public Properties

        public string RepositoryFolder { get; set; }

        #endregion

        #region Constructor

        public CommitHistoryViewModel()
        {
        }

        #endregion

        #region Public Methods

        public void Initialize()
        {
            AddViewModel(RegionNames.MAIN_REGION);
        }

        #endregion
    }
}
