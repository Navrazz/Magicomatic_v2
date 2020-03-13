using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Magicomatic.Modules.Settings.Views;
using Magicomatic.Core;

namespace Magicomatic.Modules.Settings
{
    public class SettingsModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public SettingsModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.SettingsRegion, typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}