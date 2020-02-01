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
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        /// <summary>
        /// Computes x ^ ((x << offset) ^ (x >> offset));
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The shift offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vxors<T>(Vector128<T> x, [Shift] byte count)
            where T : unmanaged
                => vxor(x,vxor(vsll(x, count),vsrl(x,count)));

        /// <summary>
        /// Computes x ^ ((x << offset) ^ (x >> offset));
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The shift offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vxors<T>(Vector256<T> x, [Shift] byte count)
            where T : unmanaged
                => vxor(x,vxor(vsll(x, count),vsrl(x,count)));

    }
}
