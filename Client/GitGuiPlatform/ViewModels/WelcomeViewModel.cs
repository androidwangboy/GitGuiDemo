using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using Augmentum.CMS.ClientFramework.I18N;
using Augmentum.XGenos;
using Augmentum.XGenos.Commands;
using WindowsApplication = System.Windows;

namespace Cafe.GitGuiPlatform.ViewModels
{
    public class WelcomeViewModel : ViewModelBase, IWelcomeViewModel
    {
        #region Public Properties

        public string DemoTitle { get; set; }

        public ICommitHistoryViewModel CommitHistoryViewModel { get; set; }

        public ICommand OpenOrInitRepositoryCommand { get; set; }
        public ICommand QuitDemoCommand { get; set; }

        #endregion

        #region Private Properties

        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        #endregion

        #region Constructor

        public WelcomeViewModel(ICommitHistoryViewModel commitHistoryViewModel)
        {
            CommitHistoryViewModel = commitHistoryViewModel;

            OpenOrInitRepositoryCommand = new DelegateCommand(OnClickInitRepositoryCommand);
            QuitDemoCommand = new DelegateCommand(OnClickQuitDemoCommand);
        }

        #endregion

        #region Public Methods

        public void Initialize()
        {
            DemoTitle = string.Format(I18NUtility.GetsI18NValue(GitGuiPlatformConstants.DEMO_TITLE));
            AddViewModel(RegionNames.MAIN_REGION);
        }

        #endregion

        #region Commands

        public void OnClickInitRepositoryCommand()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectPath = folderBrowserDialog.SelectedPath;
                DirectoryInfo workingDirectory = new DirectoryInfo(selectPath);
                if (workingDirectory.GetDirectories().Select(x => x.Name).Contains(".git"))
                {
                    ClearViewModels(RegionNames.MAIN_REGION);
                    CommitHistoryViewModel.Initialize();
                }
                else
                {
                    MessageBox.Show("您选择的文件夹不是一个Git目录.");
                }
            }
        }

        public void OnClickQuitDemoCommand()
        {
            WindowsApplication.Application.Current.Shutdown();
        }

        #endregion

    }
}