using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Magicomatic.Modules.Decks.Views;
using Magicomatic.Core;

namespace Magicomatic.Modules.Decks
{
    public class DecksModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public DecksModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.DecksRegion, typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}