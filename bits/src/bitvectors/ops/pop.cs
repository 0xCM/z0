//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<T>(BitVector<T> x)
            where T : unmanaged
                => gbits.pop(x.data);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.pop(x.data);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<N,T>(in BitVector128<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.pop(x.data.AsUInt64().GetElement(0)) + gbits.pop(x.data.AsUInt64().GetElement(1));

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(BitVector4 x)
            => gbits.pop(x.data);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(BitVector8 x)
            => gbits.pop(x.data);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(BitVector16 x)
            => gbits.pop(x.data);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(BitVector32 x)
            => gbits.pop(x.data);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(BitVector64 x)
            => gbits.pop(x.data);

        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static uint pop(in BitVector128 x)
            => gbits.pop(x.x0) + gbits.pop(x.x1);
    }
}