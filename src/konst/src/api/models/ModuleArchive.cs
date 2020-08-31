//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly struct ModuleArchive
    {
        public readonly FolderPath Root;

        public readonly Files Files;

        public readonly IPart[] Parts;

        public readonly Assembly[] Owners;

        public readonly ApiSet Api {get;}

        public ModuleArchive(Assembly[] src)
        {
            Root = FolderPath.Empty;
            Parts = ApiQuery.parts(src);
            Owners = Parts.Select(x => x.Owner);
            Files = Owners.Select(x => FilePath.Define(x.Location));
            Api = ApiQuery.apiset(new ApiParts(Parts));
        }

        public ModuleArchive(FS.FolderPath root, string exclude = EmptyString)
        {
            Root = FolderPath.Define(root.Name);
            Files = root.Exclude(text.ifblank(exclude, "System.Private.CoreLib")).Where(f => FS.managed(f)).Map(f => FilePath.Define(f.Name));
            Parts = ApiQuery.resolve(Files);
            Owners = ApiQuery.parts(Files);
            Api = ApiQuery.apiset(new ApiParts(Parts));
        }
    }
}