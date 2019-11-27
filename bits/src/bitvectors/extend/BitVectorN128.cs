//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitVectorX
    {
        /// <summary>
        /// Converts the vector to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<N,T>(this BitVector128<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitString.from(src.data, src.Width);

        [MethodImpl(Inline)]
        public static string Format<N,T>(this BitVector128<N,T> src, BitFormat? fmt = null)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.format(src, fmt);
        
        [MethodImpl(Inline)]
        public static BitCells<N,T> ToBitCells<N,T>(this BitVector128<N,T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitCells.load(src.data.ToSpan(),n);

    }
}