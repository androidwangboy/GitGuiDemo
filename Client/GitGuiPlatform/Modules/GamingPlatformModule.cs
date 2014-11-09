using System;
using System.Windows;

using Augmentum.CMS.ClientFramework.I18N;
using Augmentum.XGenos;
using Augmentum.XGenos.Logging;
using Cafe.GitGuiPlatform.ViewModels;

namespace Cafe.GitGuiPlatform.Modules
{
    /// <summary>
    /// 
    /// </summary>
    public class GamingPlatformModule : ModuleBase
    {
        #region Public Fields

        public ILogger Logger { get; set; }

        #endregion

        #region Protected Methods Override ModuleBase

        protected override void RegisterMessageServices()
        {
            OnStart();
        }

        protected override void RegisterTypes()
        {
        }

        protected override void SubscribeEvents()
        {
            EventAggregator.GetEvent<DemoStartUpEvent>().Subscribe(OnDemoStartUpEvent, true);
        }

        #endregion

        #region Public Methods

        public void OnDemoStartUpEvent(object payload)
        {
            IWelcomeViewModel welcomeViewModel = Container.Resolve<IWelcomeViewModel>();
            welcomeViewModel.Initialize();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// On start method called when application initialized.
        /// </summary>
        private void OnStart()
        {
            LoadDataTemplate();
            GetModuleInternationalization();
        }

        /// <summary>
        /// Loads view and viewmdoel data template.
        /// </summary>
        private void LoadDataTemplate()
        {
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
            {
                Source = new Uri("/GitGuiPlatform;component/DataTemplate/ViewDataTemplate.xaml", UriKind.Relative)
            });
        }

        /// <summary>
        /// Load I18N language.
        /// </summary>
        private void GetModuleInternationalization()
        {
            LanguageManager.Current.LoadLanguageBySuffix(GitGuiPlatformConstants.GITGUIPLATFORM_LANGUAGE_SUFFIX);
        }

        #endregion
    }
}
