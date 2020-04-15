//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {

        [MethodImpl(Inline)]
        public static void CopyTo<N,T>(this in NatSpan<N,T> src,Span<T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.CopyTo(dst);
    }
}