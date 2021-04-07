//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;

    public class ApiParts : IApiParts
    {
        /// <summary>
        /// The root of the archive one which the api module set is predicated
        /// </summary>
        public FS.FolderPath Source {get;}

        public FS.Files ManagedSources {get;}

        public Assembly[] Components {get;}

        public IApiCatalogDataset ApiCatalog {get;}

        public ApiParts(PartId[] parts)
        {
            Source = FS.path(root.controller().Location).FolderPath;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            ApiCatalog = ApiCatalogs.dataset(parts);
            Components = ApiCatalog.PartComponents;
        }

        public ApiParts(FS.FolderPath source)
        {
            Source = source;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            ApiCatalog =  ApiCatalogs.dataset(ManagedSources);
            Components = ApiCatalog.PartComponents;
        }
    }
}