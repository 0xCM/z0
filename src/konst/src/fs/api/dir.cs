//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static FolderPath dir(PathPart name)
            => new FolderPath(name);

        public static FilePath[] dir(FolderPath src, FileExt ext, bool recurse = false)
        {
            var legacy = new Z0.FolderPath(src.Name);
            var result = legacy.Files(new Z0.FileExtension(ext.Name), recurse);
            return result.Map(x => path(x.Name));
        }                

        public static FilePath[] dir(FolderPath src)
        {
            var legacy = new Z0.FolderPath(src.Name);
            var result = legacy.AllFiles;
            return result.Map(x => path(x.Name));
        }
    }
}