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
        public FolderPath Root {get;}

        public readonly Files Files;

        public readonly IPart[] Parts;

        public readonly Assembly[] Components;

        public ModuleArchive(Assembly[] src)
        {
            Root = FolderPath.Empty;
            Parts = ApiQuery.parts(src);
            Components = Parts.Select(x => x.Owner);
            Files = Components.Select(x => FilePath.Define(x.Location));
        }

        public ModuleArchive(FolderPath root)
        {
            Root = root;
            Files = root.Files().Where(f => FS.managed(FS.path(f.Name)));
            insist(Files.Count != 0, $"The files in {root}, there must be some");
            Parts = Parted.resolve(Files);
            Components = Parted.parts(Files);
        }
    }
}