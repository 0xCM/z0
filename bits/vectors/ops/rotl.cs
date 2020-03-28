//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static root;    

    partial class BitVector
    {
        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> rotl<T>(BitVector<T> x, int s)
            where T : unmanaged
                => gbits.rotl(x.Scalar,s);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector4 rotl(BitVector4 x, int s)
            => gbits.rotl(x.Scalar, s, x.Width);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector8 rotl(BitVector8 x, int s)
            => gbits.rotl(x.Scalar,s);
            
        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector16 rotl(BitVector16 x, int s)
            => gbits.rotl(x.Scalar,s);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector32 rotl(BitVector32 x, int s)
            => gbits.rotl(x.Scalar,s);

        /// <summary>
        /// Rotates source bits leftward
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static BitVector64 rotl(BitVector64 x, int s)
             => gbits.rotl(x.Scalar,s);
    }
}