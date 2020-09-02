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

        public readonly Files Files;

        public readonly IPart[] Parts;

        public readonly Assembly[] Owners;

        public readonly ApiSet Api {get;}

        public ModuleArchive(FS.FolderPath root)
        {
            Root = root;
            Files = root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f)).Map(f => FilePath.Define(f.Name));
            Parts = ApiQuery.resolve(Files);
            Owners = ApiQuery.parts(Files);
            Api = ApiQuery.apiset(new ApiParts(Parts));
        }

        public ModuleArchive(Assembly root, PartId[] parts)
        {
            Root = FS.path(root.Location).FolderPath;
            Files = Root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f)).Map(f => FilePath.Define(f.Name));
            Parts =  parts.Length != 0 ? ApiQuery.resolve(Files).Where(x => parts.Contains(x.Id)) : ApiQuery.resolve(Files);
            Owners = Parts.Select(x => x.Owner);
            Api = ApiQuery.apiset(new ApiParts(Parts));
        }

        public ModuleArchive(Assembly root)
        {
            Root = FS.path(root.Location).FolderPath;
            Files = Root.Exclude("System.Private.CoreLib").Where(f => FS.managed(f)).Map(f => FilePath.Define(f.Name));
            Parts =  ApiQuery.resolve(Files);
            Owners = Parts.Select(x => x.Owner);
            Api = ApiQuery.apiset(new ApiParts(Parts));
        }
    }
}