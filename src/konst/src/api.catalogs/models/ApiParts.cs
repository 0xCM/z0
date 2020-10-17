//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    using static Konst;
    using static z;

    public readonly struct ApiPartSet : IApiParts
    {
        /// <summary>
        /// The root of the archive one which the api module set is predicated
        /// </summary>
        public FS.FolderPath Source {get;}

        public readonly FS.Files ManagedSources;

        public readonly Assembly[] Components;

        public readonly SystemApiCatalog Api;

        FS.Files IApiParts.ManagedSources
            => ManagedSources;

        Assembly[] IApiParts.Components
            => Components;

        ISystemApiCatalog IApiParts.Api
            => Api;

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
            Api =  parts.Length != 0 ? new SystemApiCatalog(ApiCatalogs.system(ManagedSources).Parts.Where(x => parts.Contains(x.Id))) : ApiCatalogs.system(ManagedSources);
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