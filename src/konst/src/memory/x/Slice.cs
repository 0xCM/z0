//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static partial class XTend
    {
        [MethodImpl(Inline)]
        public static Span<T> Slice<N,T>(this in NatSpan<N,T> src, int offset)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.Slice(offset);

        [MethodImpl(Inline)]
        public static Span<T> Slice<N,T>(this in NatSpan<N,T> src, int offset, int length)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.Slice(offset, length);
    }
}