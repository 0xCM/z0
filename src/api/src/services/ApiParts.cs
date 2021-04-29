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

        public Index<Assembly> Components
            => RuntimeCatalog.Components;

        public IApiRuntimeCatalog RuntimeCatalog {get;}

        public ApiParts(PartId[] parts)
        {
            var control =  FS.path(root.controller().Location);
            Source = control.FolderPath;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            RuntimeCatalog = ApiDeployment.catalog(Source,parts);
        }

        public ApiParts(FS.FolderPath source)
        {
            Source = source;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            RuntimeCatalog = ApiDeployment.catalog(ManagedSources);
        }
    }
}