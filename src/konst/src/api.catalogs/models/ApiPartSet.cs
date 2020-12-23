//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Associates a collection of components along with a<see cref = 'ISystemApiCatalog'/>
    /// </summary>
    public readonly struct ApiPartSet : IApiParts
    {
        /// <summary>
        /// The root of the archive one which the api module set is predicated
        /// </summary>
        public FS.FolderPath Source {get;}

        public FS.Files ManagedSources {get;}

        public Assembly[] Components {get;}

        public ISystemApiCatalog Api {get;}

        public ApiPartSet(FS.FolderPath src)
        {
            Source = src;
            ManagedSources = src.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Components = ApiQuery.components(ManagedSources);
            Api = ApiCatalogs.system(ManagedSources);
        }

        public ApiPartSet(Assembly src, PartId[] parts)
        {
            Source = FS.path(src.Location).FolderPath;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Api = ApiCatalogs.siblings(src,parts);
            Components = Api.Components;
        }

        public ApiPartSet(Assembly src)
        {
            Source = FS.path(src.Location).FolderPath;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Api =  ApiCatalogs.system(ManagedSources);
            Components = Api.Components;
        }
    }
}