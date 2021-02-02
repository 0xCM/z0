//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a file catalog entry that specifies a path to a file
    /// </summary>
    public struct FileCatalogEntry
    {
        public FS.FilePath FilePath;

        [MethodImpl(Inline)]
        public FileCatalogEntry(FS.FilePath src)
            => FilePath = src;

        public FS.FileExt FileExt
        {
            [MethodImpl(Inline)]
            get => FilePath.Ext;
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

        [MethodImpl(Inline)]
        public static implicit operator FileCatalogEntry(FS.FilePath src)
            => new FileCatalogEntry(src);
    }
}