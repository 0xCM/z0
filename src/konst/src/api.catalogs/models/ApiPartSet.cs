//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;

    /// <summary>
    /// Associates a collection of components along with a<see cref = 'IApiCatalogDataset'/>
    /// </summary>
    public class ApiPartSet : IApiParts
    {
        /// <summary>
        /// The root of the archive one which the api module set is predicated
        /// </summary>
        public FS.FolderPath Source {get;}

        public FS.Files ManagedSources {get;}

        public Assembly[] Components {get;}

        public IApiCatalogDataset ApiCatalog {get;}

        public ApiPartSet(FS.FolderPath source, PartId[] parts)
        {
            Source = source;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            ApiCatalog = ApiCatalogs.Dataset(Source, parts);
            Components = ApiCatalog.PartComponents;
        }

        public ApiPartSet(FS.FolderPath source)
        {
            Source = source;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            ApiCatalog =  ApiCatalogs.Dataset(ManagedSources);
            Components = ApiCatalog.PartComponents;
        }

        public bool Component(PartId part, out Assembly component)
        {
            var components = @readonly(Components);
            var count = Components.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var candidate = ref skip(components,i);
                if(candidate.Id() == part)
                {
                    component = candidate;
                    return true;
                }
            }
            component = default;
            return false;
        }
    }
}