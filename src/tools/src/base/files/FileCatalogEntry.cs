//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using Z0.Data;

    using static Konst;

    public struct FileCatalogEntry : ITable<FileCatalogEntryField,FileCatalogEntry>
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