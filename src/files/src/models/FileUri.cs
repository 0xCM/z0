//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct FS
    {
        public readonly struct FileUri : ITextual
        {
            readonly FilePath Source;

            [MethodImpl(Inline)]
            public static implicit operator FileUri(FilePath src)
                => new FileUri(src);

            [MethodImpl(Inline)]
            public FileUri(FilePath src)
                => Source = src.Replace("file:///", EmptyString);

            public string Format()
                => Z0.text.format("file:///{0}", Source.Format());

            public string FormatMarkdown(string label = null)
                => string.Format("{0}: <{1}>", label ?? Source.FileName.Format(), Format());

            public override string ToString()
                => Format();
        }
    }
}