//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly struct ModuleArchives
    {
        public static ModuleArchive entry()
        {
            var entry = Assembly.GetEntryAssembly();
            var path = FilePath.Define(entry.Location);
            insist(path.Exists, $"The file for {entry}, it must exist");
            return from(FS.dir(path.FolderPath.Name));
        }

        [MethodImpl(Inline)]
        public static ModuleArchive from(FolderPath src)
            => new ModuleArchive(FS.dir(src.Name));

        [MethodImpl(Inline)]
        public static ModuleArchive from(FS.FolderPath src, PartId[] parts)
            => new ModuleArchive(FS.dir(src.Name), parts);

        public static ModuleArchive exclude(string exclude)
        {
            var entry = Assembly.GetEntryAssembly();
            var path = FS.path(entry.Location);
            insist(path.Exists, $"The file for {entry}, it must exist");
            return from(path.FolderPath, exclude);
        }

        [MethodImpl(Inline)]
        public static ModuleArchive from(FS.FolderPath src, string exclusions = EmptyString)
            => new ModuleArchive(src, exclusions);

        [MethodImpl(Inline)]
        public static ModuleArchive from(params Assembly[] src)
            => new ModuleArchive(src);
    }
}