//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static z;
    using static FileExtensions;

    [FileArchive]
    public readonly struct ImageArchive : IFileArchive
    {
        public FS.FolderPath Root {get;}

        public ImageFormatKind FormatKind {get;}

        public FS.FileExt[] Extensions {get;}

        public ImageArchive(FS.FolderPath root, ImageFormatKind kind)
        {
            Root = root;
            FormatKind = kind;
            Extensions = extensions(kind);
        }

        public ListedFiles Listing()
            => FS.list(Files().Array());

        public IEnumerable<FS.FilePath> Files()
            => Root.EnumerateFiles(true);

        static FS.FileExt[] extensions(ImageFormatKind kind)
            => kind switch {
                ImageFormatKind.Csv => array(Csv),
                _ => array(Dll, Exe, Pdb)
            };
    }
}