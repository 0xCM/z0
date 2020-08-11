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

    /// <summary>
    /// Defines a file catalog entry that specifies a path to a file
    /// </summary>
    public struct FileCatalogEntry : ITable<FileCatalogField,FileCatalogEntry>
    {
        public string FileExt;

        public string FileName;

        public string FolderName;

        public string FilePath;

        [MethodImpl(Inline)]
        public FileCatalogEntry(string path)
        {
            FileExt = Path.GetExtension(path);
            FileName = Path.GetFileName(path);
            FolderName = Path.GetDirectoryName(path);
            FilePath = path;
        }

        [MethodImpl(Inline)]
        public FileCatalogEntry(string ext, string name, string folder, string path)
        {
            FileExt = ext;
            FileName = name;
            FolderName = name;
            FilePath = path;
        }
    }
}