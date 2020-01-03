//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Creates an N-bit vector directly from the source data, bypassing masked initialization
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        internal static BitVector<N,T> inject<N,T>(T src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector<N,T>.Inject(src);

        /// <summary>
        /// Creates a 4-bit vector directly from the source data, bypassing masked initialization
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        internal static BitVector4 inject(N4 n, byte data)
            => new BitVector4(data,true);

    }
}