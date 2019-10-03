//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<N256,ushort> bitvector(in BitMatrix16 A)
            => BitVector.Load(A.Data, n256);

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<N1024,uint> bitvector(in BitMatrix32 A)
            => BitVector.Load(A.Data, n1024);

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<N4096,ulong> bitvector(in BitMatrix64 A)
            => BitVector.Load(A.Data, n4096);
    }
}