//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class BitVector
    {
        /// <summary>
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 extend(BitVector4 src, N8 n)
            => BitVector.create(n, src.data);

        /// <summary>
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 extend(BitVector8 src, N16 n)
            => BitVector.create(n, src.data);

        /// <summary>
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 extend(BitVector16 src, N32 n)
            => BitVector.create(n, src.data);

        /// <summary>
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 extend(BitVector32 src, N64 n)
            => BitVector.create(n, src.data);

        /// <summary>
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline), Op]
        public static BitVector128<N128,ulong> extend(BitVector64 src, N128 n)
            => new BitVector128<N128, ulong>(VCoreD.vscalar(n,src));
    }
}