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

    public readonly struct ModuleArchive
    {
        public readonly FS.FolderPath Root;

        public readonly FS.Files Files;

        public readonly ApiParts Parts;

        public readonly Assembly[] Components;

        public readonly ApiParts Api {get;}

        public ModuleArchive(FS.FolderPath root)
        {
            Root = root;
            Files = root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Parts = ApiQuery.resolve(Files);
            Components = ApiQuery.parts(Files);
            Api = Parts;
        }

        public ModuleArchive(Assembly root, PartId[] parts)
        {
            Root = FS.path(root.Location).FolderPath;
            Files = Root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Parts =  parts.Length != 0 ? ApiQuery.resolve(Files).Where(x => parts.Contains(x.Id)) : ApiQuery.resolve(Files);
            Components = Parts.Components;
            Api = Parts;
        }

        public ModuleArchive(Assembly root)
        {
            Root = FS.path(root.Location).FolderPath;
            Files = Root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            Parts =  ApiQuery.resolve(Files);
            Components = Parts.Components;
            Api = Parts;
        }
    }
}