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

    partial class bitvector
    {
        /// <summary>
        /// Computes the bitwise AND between two generic bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> inc<T>(BitVector<T> x)
            where T : unmanaged
                => gmath.inc(x.Data);


        [MethodImpl(Inline)]
        public static BitVector4 inc(BitVector4 x)
        {
            if(x.data < 0xF)
                return x.data++;
            else
                return BitVector4.Zero;
        }

        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 inc(BitVector8 x)        
            => math.inc(x.data);
        
        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 inc(BitVector16 x)        
            => math.inc(x.data);

        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 inc(BitVector32 x)        
            => math.inc(x.data);

        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 inc(BitVector64 x)        
            => math.inc(x.data);
    }
}