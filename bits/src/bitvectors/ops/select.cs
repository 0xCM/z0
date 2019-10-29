//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;
    using static As;

    partial class BitVector
    {
        /// <summary>
        /// Computes the bitwise selection among three generic source vectors
        /// </summary>
        /// <param name="x">The pivot vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector<T> select<T>(BitVector<T> x, BitVector<T> y, BitVector<T> z)
            where T : unmanaged
                => gmath.select(x.Data,y.Data, z.Data);

        /// <summary>
        /// Computes the bitwise selection among three source vectors
        /// </summary>
        /// <param name="x">The pivot vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector4 select(BitVector4 x, BitVector4 y, BitVector4 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise selection among three source vectors
        /// </summary>
        /// <param name="x">The pivot vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector8 select(BitVector8 x, BitVector8 y, BitVector8 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise selection among three source vectors
        /// </summary>
        /// <param name="x">The pivot vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector16 select(BitVector16 x, BitVector16 y, BitVector16 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise selection among three source vectors
        /// </summary>
        /// <param name="x">The pivot vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector32 select(BitVector32 x, BitVector32 y, BitVector32 z)
            => gmath.select(x.data, y.data, z.data);

        /// <summary>
        /// Computes the bitwise selection among three source vectors
        /// </summary>
        /// <param name="x">The pivot vector</param>
        /// <param name="y">The primary choice</param>
        /// <param name="z">The alternative choice</param>
        [MethodImpl(Inline)]
        public static BitVector64 select(BitVector64 x, BitVector64 y, BitVector64 z)
            => gmath.select(x.data, y.data, z.data);

    }
}