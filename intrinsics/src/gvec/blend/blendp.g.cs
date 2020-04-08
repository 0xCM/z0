//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Core;
    using static Gone2;

    partial class gvec
    {
        /// <summary>
        /// Efects a "paired" or "permutation" blend that computes vectors
        /// lo := vblendv(x,y,spec)
        /// hi := vblendv(x,y,vnot(spec))
        /// that, taken together, define a permutation on the source vector components
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="spec">The blend spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector512<T> vblendp<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)        
            where T : unmanaged
                => (vblendv(x,y,spec),vblendv(x,y,vnot(spec)));

        /// <summary>
        /// Efects a "paired" or "permutation" blend that computes vectors
        /// lo := vblendv(x,y,spec)
        /// hi := vblendv(x,y,vnot(spec))
        /// that, taken together, define a permutation on the source vector components
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="spec">The blend spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector512<T> vblendp<T>(Vector512<T> x, Vector256<T> spec)        
            where T : unmanaged
                => (vblendv(x.Lo,x.Hi,spec),vblendv(x.Lo,x.Hi,vnot(spec)));

        /// <summary>
        /// Efects a "paired" or "permutation" blend that computes vectors
        /// lo := vblendv(x,y,spec)
        /// hi := vblendv(x,y,vnot(spec))
        /// that, taken together, define a permutation on the source vector components
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="spec">The blend spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vblendp<T>(Vector128<T> x, Vector128<T> y, Vector128<T> spec)        
            where T : unmanaged
                => Vectors.vconcat(vblendv(x,y,spec),vblendv(x,y,vnot(spec)));

        /// <summary>
        /// Efects a "paired" or "permutation" blend that computes vectors
        /// lo := vblendv(x,y,spec)
        /// hi := vblendv(x,y,vnot(spec))
        /// that, taken together, define a permutation on the source vector components
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="spec">The blend spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vblendp<T>(Vector256<T> x, Vector128<T> spec)        
            where T : unmanaged
                => Vectors.vconcat(vblendv(vlo(x),vhi(x),spec),vblendv(vlo(x),vhi(x),vnot(spec)));

    }

}