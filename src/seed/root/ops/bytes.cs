//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial class RootLegacy
    {     

        [MethodImpl(Inline)]
        public static Span<byte> bytes<T>(in T src)
            where T : struct
                => As.bytes(src);        

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
            where T : struct
                => As.bytes(src);
    }
}