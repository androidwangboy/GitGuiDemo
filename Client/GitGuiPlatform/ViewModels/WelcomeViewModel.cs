using System;
using System.Windows.Input;
using Augmentum.CMS.ClientFramework.I18N;
using Augmentum.XGenos;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class WelcomeViewModel : ViewModelBase, IWelcomeViewModel
    {
        #region Public Properties

        public string DemoTitle { get; set; }

        public ICommand OpenOrInitRepositoryCommand { get; set; }
        public ICommand QuitDemoCommand { get; set; }

        #endregion

        #region Constructor

        public WelcomeViewModel()
        {
        }

        #endregion

        #region Public Methods

        public void Initialize()
        {
            DemoTitle = string.Format(I18NUtility.GetsI18NValue(GitGuiPlatformConstants.DEMO_TITLE));
            AddViewModel(RegionNames.MAIN_REGION);
        }

        #endregion
    }
}