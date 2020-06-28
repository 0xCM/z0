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

    partial struct As
    {        
        /// <summary>
        /// Presents a vector over T-cells as a vector over i8 cells
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector128<byte> v8u<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsByte();

        /// <summary>
        /// Presents a vector over T-cells as a vector over u8 cells
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector256<byte> v8u<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsByte();

        /// <summary>
        /// Presents a vector over T-cells as a vector over u8 cells
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector512<byte> v8u<T>(Vector512<T> x)
            where T : unmanaged
                => x.As<byte>();
    }
}