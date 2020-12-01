//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    using static ArchiveFileKinds;

    [FileArchive]
    public readonly struct ImageArchive : IFileArchive<ImageFormatKind>
    {
        public FS.FolderPath Root {get;}

        public ImageFormatKind ArchiveKind {get;}

        public FS.FileExt[] Extensions {get;}

        public ImageArchive(FS.FolderPath root, ImageFormatKind kind)
        {
            Root = root;
            ArchiveKind = kind;
            Extensions = extensions(kind);
        }

        public ListedFiles List()
            => FS.list(Files().Array());

        public IEnumerable<FS.FilePath> Files()
            => Root.EnumerateFiles(true);

        static FS.FileExt[] extensions(ImageFormatKind kind)
            => kind switch {
                ImageFormatKind.Csv => array(Csv),
                _ => array(Dll,Exe,Pdb)
            };
    }

    public enum ImageFormatKind
    {
        None = 0,

        Binary = 1,

        Csv = 2,
    }
}