//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a file catalog entry that specifies a path to a file
    /// </summary>
    public struct FileCatalogEntry : ITable<FileCatalogEntry>
    {
        public FS.FilePath FilePath;

        [MethodImpl(Inline)]
        public static implicit operator FileCatalogEntry(FS.FilePath src)
            => new FileCatalogEntry(src);

        [MethodImpl(Inline)]
        public FileCatalogEntry(FS.FilePath src)
            => FilePath = src;

        public FS.FileExt FileExt
        {
            [MethodImpl(Inline)]
            get => FilePath.FileExt;
        }

        public FS.FileName FileName
        {
            [MethodImpl(Inline)]
            get => FilePath.FileName;
        }

        public FS.FolderName FolderName
        {
            [MethodImpl(Inline)]
            get => FilePath.FolderName;
        }
    }
}