//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline)]
        public static BitVector8 Expand(this BitVector4 src, N8 n)
            => BitVector.from(n, src.data);

        /// <summary>
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline)]
        public static BitVector16 Expand(this BitVector8 src, N16 n)
            => BitVector.from(n, src.data);

        /// <summary>
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline)]
        public static BitVector32 Expand(this BitVector16 src, N32 n)
            => BitVector.from(n, src.data);

        /// <summary>
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline)]
        public static BitVector64 Expand(this BitVector32 src, N64 n)
            => BitVector.from(n, src.data);

        /// <summary>
        /// Zero extends the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width</param>
        [MethodImpl(Inline)]
        public static BitVector128<N128,ulong> Expand(this BitVector64 src, N128 n)
            => new BitVector128<N128, ulong>(dinx.vscalar(n,src));

    }

}