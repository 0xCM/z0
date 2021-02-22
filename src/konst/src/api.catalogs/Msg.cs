//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial struct Msg
    {
        public static RenderPattern<Count> IndexingPartFiles => "Indexing {0} partfile datasets";

        public static RenderPattern<FS.FilePath> IndexingCodeBlocks => "Indexing code blocks from {0}";

        public static RenderPattern<Count,FS.FilePath> AbsorbedCodeBlocks => "Absorbed {0} code blocks from {1}";

        public static RenderPattern<OpUri> Unbased => "The block {0} has no base addressed";

        public static RenderPattern<OpUri> DuplicateUri => "The uri {0} has been duplicated";

        public static string Unparsed<T>(T src) => unparsed<T>().Format(src);

        static RenderPattern<T> unparsed<T>() => "Unable to parse {0}";
    }
}