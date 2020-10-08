//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Db
    {
        public readonly struct ContentKind
        {
            readonly StringRef Ref;

            [MethodImpl(Inline)]
            public ContentKind(string src)
                => Ref = src;

            public ReadOnlySpan<char> Data
            {
                [MethodImpl(Inline)]
                get => Ref.View;
            }

            [MethodImpl(Inline)]
            public static implicit operator ContentKind(string src)
                => new ContentKind(src);
        }
    }
}