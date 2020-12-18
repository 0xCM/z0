//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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
                => Source = src;

            [MethodImpl(Inline)]
            public string Format()
                => text.format("file:///{0}", Source.Format());

            public override string ToString()
                => Format();
        }
    }
}