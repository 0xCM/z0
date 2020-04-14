//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static BitString ToBitString<N,T>(this BitBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitString.scalars(src.Data, src.Width); 
    }
}