//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Implements component-wise vector contraction
    /// </summary>
    partial class RngX
    {        
        /// <summary>
        /// Effects a component-wise contraction on the source vector on a source vector of unsigned primal type, 
        /// dst[i] = src[i].Contract(max[i])
        /// </summary>
        /// <param name="src">The vector to contract</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The unsigned primal type</typeparam>
         public static RowVector256<N,T> Contract<N,T>(this RowVector256<N,T> src, RowVector256<N,T> max)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = Z0.NatSpan.alloc<N, T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Scale.contract(src[i],max[i]);
            return dst;
        }

         public static NatSpan<N,T> Contract<N,T>(this NatSpan<N,T> src, NatSpan<N,T> max)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = Z0.NatSpan.alloc<N, T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Scale.contract(src[i],max[i]);
            return dst;
        }

        /// <summary>
        /// Effects a component-wise contraction on the source vector on a source vector of unsigned primal type, 
        /// dst[i] = src[i].Contract(max[i])
        /// </summary>
        /// <param name="src">The vector to contract</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The unsigned primal type</typeparam>
         public static RowVector256<T> Contract<T>(this RowVector256<T> src, RowVector256<T> max)
            where T : unmanaged
        {
            var len = src.Length;
            require(len == max.Length);
            var dst = Z0.RowVector.blockalloc<T>(len);
            for(var i=0; i<dst.Length; i++)
                dst[i] = Scale.contract(src[i],max[i]);
            return dst;
        }
 
        [MethodImpl(Inline)]
        internal static Interval<T> Configure<T>(this Interval<T>? domain)        
            where T : unmanaged
                => domain.ValueOrElse(() => Rng.TypeDomain<T>());

        [MethodImpl(Inline)]
        internal static Interval<T> DefaultDomain<T>()        
            where T : unmanaged
                => Rng.TypeDomain<T>();

        [MethodImpl(Inline)]
        static T TypeMin<T>()
            where T : unmanaged
                => minval<T>();
        
        [MethodImpl(Inline)]
        static T TypeMax<T>()
            where T : unmanaged
                => maxval<T>();

    }
}