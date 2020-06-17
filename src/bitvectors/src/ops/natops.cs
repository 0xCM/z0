//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst; 
    using static Memories;    

    partial class BitVector
    {      
        /// <summary>
        /// Computes the effective width of the bitvector as determined by the number of leading zero bits
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static int width<N,T>(BitVector<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => x.Width - nlz(x);

        public static BitVector<N,T> perm<N,T>(BitVector<N,T> src, in Perm spec)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var dst = src.Replicate();
            var n = src.Width;
            for(var i=0; i<n; i++)
                dst[i] = src[spec[i]];
            return dst;
        }


        /// <summary>
        /// Counts the number of enabled bits in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint pop<N,T>(in BitVector128<N,T> x)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gbits.pop(x.Data.AsUInt64().GetElement(0)) + gbits.pop(x.Data.AsUInt64().GetElement(1));
    }
}