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

    public readonly struct ApiModules
    {
        /// <summary>
        /// The root of the archive one which the api module set is predicated
        /// </summary>
        public readonly FS.FolderPath Root;

        public readonly FS.Files ManagedSources;

        public readonly Assembly[] Assemblies;

        public readonly ApiParts Api;

        public ApiModules(FS.FolderPath root)
        {
            Root = root;
            ManagedSources = root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Assemblies = ApiQuery.components(ManagedSources);
            Api = ApiQuery.parts(ManagedSources);
        }

        public ApiModules(Assembly root, PartId[] parts)
        {
            Root = FS.path(root.Location).FolderPath;
            ManagedSources = Root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Api =  parts.Length != 0 ? ApiQuery.parts(ManagedSources).Storage.Where(x => parts.Contains(x.Id)) : ApiQuery.parts(ManagedSources);
            Assemblies = Api.Components;
        }

        public ApiModules(Assembly root)
        {
            Root = FS.path(root.Location).FolderPath;
            ManagedSources = Root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Api =  ApiQuery.parts(ManagedSources);
            Assemblies = Api.Components;
        }
    }
}