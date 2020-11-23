//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = FS;


    public readonly struct FileType
    {
        public ContentKind ContentKind {get;}

        public IndexedSeq<FS.FileExt> Extensions {get;}

        public FileType(ContentKind kind, FS.FileExt[] extensions)
        {
            ContentKind = kind;
            Extensions = extensions;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }

    partial class XTend
    {
        public static DelimitedList<T> Delimited<T>(this IIndex<T> src, char delimiter = Chars.Comma)
            => z.delimit(src.Storage, delimiter);
    }
}