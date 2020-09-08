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
        public readonly FS.FolderPath Root;

        public readonly FS.Files Files;

        public readonly Assembly[] Components;

        public readonly ApiParts Parts;

        public readonly ApiParts Api {get;}

        public ApiModules(FS.FolderPath root)
        {
            Root = root;
            Files = root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Components = ApiQuery.parts(Files);
            Parts = ApiQuery.resolve(Files);
            Api = Parts;
        }

        public ApiModules(Assembly root, PartId[] parts)
        {
            Root = FS.path(root.Location).FolderPath;
            Files = Root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Parts =  parts.Length != 0 ? ApiQuery.resolve(Files).Where(x => parts.Contains(x.Id)) : ApiQuery.resolve(Files);
            Components = Parts.Components;
            Api = Parts;
        }

        public ApiModules(Assembly root)
        {
            Root = FS.path(root.Location).FolderPath;
            Files = Root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Parts =  ApiQuery.resolve(Files);
            Components = Parts.Components;
            Api = Parts;
        }
    }
}