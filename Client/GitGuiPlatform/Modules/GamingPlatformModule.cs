using System;
using System.Windows;

using Augmentum.CMS.ClientFramework.I18N;
using Augmentum.XGenos;
using Augmentum.XGenos.Logging;

namespace Cafe.GitGuiPlatform.Modules
{
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
            EventAggregator.GetEvent<TableStartupEvent>().Subscribe(OnTableStartupEvent, true);
            EventAggregator.GetEvent<PlayerListStartupEvent>().Subscribe(OnPlayerListStartupEvent, true);
            EventAggregator.GetEvent<SearchPageStartupEvent>().Subscribe(OnSearchPageStartupEvent, true);
        }

        #endregion

        #region Public Methods

        public void OnTableStartupEvent(object payload)
        {
        }
        public void OnPlayerListStartupEvent(object payload)
        {
        }
        public void OnSearchPageStartupEvent(object payload)
        {
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
