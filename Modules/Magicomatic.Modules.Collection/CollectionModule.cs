﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Magicomatic.Modules.Collection.Views;
using Magicomatic.Core;

namespace Magicomatic.Modules.Collection
{
    public class CollectionModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public CollectionModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.CollectionRegion, typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}