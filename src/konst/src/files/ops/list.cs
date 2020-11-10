//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    partial struct FS
    {
        [Op]
        public static ListedFiles list(FilePath[] src)
            => new ListedFiles(src.Mapi((i,x) => new ListedFile(i,x)));

        [MethodImpl(Inline), Op]
        public static ListedFiles list(Files src)
            => new ListedFiles(src.Data.Storage.Mapi((i,x) => new ListedFile((uint)i,x)));

        public static FilePath[] list(FolderPath src, FileExt ext, bool recurse = false)
        {
            var legacy = new Z0.FolderPath(src.Name);
            var result = legacy.Files(new Z0.FileExtension(ext.Name), recurse);
            return result.Map(x => path(x.Name));
        }

        public static FilePath[] list(FolderPath src)
        {
            var legacy = new Z0.FolderPath(src.Name);
            var result = legacy.AllFiles;
            return result.Map(x => path(x.Name));
        }
    }
}