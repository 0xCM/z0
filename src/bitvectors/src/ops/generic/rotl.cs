//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitVector
    {
        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Rotl, Closures(Closure)]
        public static BitVector<T> rotl<T>(BitVector<T> x, byte offset)
            where T : unmanaged
                => gbits.rotl(x.Data,offset);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> rotl<N,T>(BitVector<N,T> x, byte offset)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.rotl(x.Data, offset, x.Width);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="src">The source bitvector</param>
        /// <param name="offset">The rotation magnitude</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> rotl<N,T>(in BitVector128<N,T> src, byte offset)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gcpu.vrotlx(src.Data, offset);
    }
}