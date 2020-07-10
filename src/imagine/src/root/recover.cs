//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<byte> src)
            where T : struct
                => z.recover<T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<byte> src)
            where T : struct
                => z.recover<T>(src);

        [MethodImpl(Inline)]        
        public static ReadOnlySpan<T> recover<S,T>(ReadOnlySpan<S> src)                
            where S : struct
            where T : struct
                => z.recover<S,T>(src);
    }
}