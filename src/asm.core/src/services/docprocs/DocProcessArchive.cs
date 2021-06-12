//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static core;
    using static EnvFolders;

    public readonly struct DocProcessArchive : IFileArchive
    {
        public FS.FolderPath Root {get;}

        public DocProcessArchive(FS.FolderPath root)
        {
            Root = root;
        }

        public FS.FolderPath RefDocs()
            => Root + FS.folder(refs);

        public FS.FilePath RefDoc(string docid, FS.FileExt ext)
            => RefDocs() + FS.file(docid, ext);

        public FS.FolderPath DocExtracts()
            => Root + FS.folder(extracts);

        public FS.FolderPath DocExtractDir(string docid)
            => DocExtracts() + FS.folder(docid);

        public FS.FilePath DocExtract(string docid, string part, FS.FileExt ext)
            => DocExtractDir(docid) + FS.file(string.Format("{0}.{1}",docid, part), ext);

    }
}