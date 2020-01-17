//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Arithmetically increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> inc<T>(BitVector<T> x)
            where T : unmanaged
                => gmath.inc(x.data);

        [MethodImpl(Inline), Op]
        public static BitVector4 inc(BitVector4 x)
        {
            if(x.data < 0xF)
                return x.data++;
            else
                return BitVector4.Zero;
        }

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 inc(BitVector8 x)        
            => gmath.inc(x.data);
        
        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 inc(BitVector16 x)        
            => gmath.inc(x.data);

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 inc(BitVector32 x)        
            => gmath.inc(x.data);

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 inc(BitVector64 x)        
            => gmath.inc(x.data);
    }
}