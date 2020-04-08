//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    partial class BitVector
    {    
        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 reverse(BitVector4 x)        
            => gbits.rev(x.data);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 reverse(BitVector8 x)        
            => gbits.rev(x.data);
        
        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 reverse(BitVector16 x)        
            => gbits.rev(x.data);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 reverse(BitVector32 x)        
            => gbits.rev(x.data);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 reverse(BitVector64 x)        
            => gbits.rev(x.data);

        /// <summary>
        /// Reverses the bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitVector<T> reverse<T>(BitVector<T> x)
            where T : unmanaged
                => gbits.rev(x.Scalar);

    }
}