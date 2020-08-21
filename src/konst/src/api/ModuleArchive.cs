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
        public static ModuleArchive executing()
        {
            var entry = Assembly.GetEntryAssembly();
            var path = FilePath.Define(entry.Location);
            insist(path.Exists, $"The file for {entry}, it must exist");
            return from(path.FolderPath);
        }

        [MethodImpl(Inline)]
        public static ModuleArchive from(FolderPath src)
            => new ModuleArchive(src);

        public static ModuleArchive from(Type src)
            => from(FilePath.Define(src.Assembly.Location).FolderPath);
    }
}