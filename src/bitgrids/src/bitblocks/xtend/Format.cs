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
        public static string Format<N,T>(this BitBlock<N,T> src, BitFormatConfig? config = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToBitString().Format(config);
    }
}