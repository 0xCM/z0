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

    public readonly struct ApiPartSet
    {
        /// <summary>
        /// The root of the archive one which the api module set is predicated
        /// </summary>
        public FS.FolderPath Root {get;}

        public readonly FS.Files ManagedSources;

        public Assembly[] Assemblies {get;}

        public readonly SystemApiCatalog Api;

        public ApiPartSet(FS.FolderPath root)
        {
            Root = root;
            ManagedSources = root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Assemblies = ApiQuery.components(ManagedSources);
            Api = ApiCatalogs.system(ManagedSources);
        }

        public ApiPartSet(Assembly root, PartId[] parts)
        {
            Root = FS.path(root.Location).FolderPath;
            ManagedSources = Root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Api =  parts.Length != 0 ? new SystemApiCatalog(ApiCatalogs.system(ManagedSources).Storage.Where(x => parts.Contains(x.Id))) : ApiCatalogs.system(ManagedSources);
            Assemblies = Api.Components;
        }

        public ApiPartSet(Assembly root)
        {
            Root = FS.path(root.Location).FolderPath;
            ManagedSources = Root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Api =  ApiCatalogs.system(ManagedSources);
            Assemblies = Api.Components;
        }
    }
}