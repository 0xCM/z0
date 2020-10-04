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

    partial class text
    {
        [MethodImpl(Inline)]
        public static uint size(Utf8 kind, ReadOnlySpan<char> src)
            => TextEncoders.size(kind,src);
    }
}