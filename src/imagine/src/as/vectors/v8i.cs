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
        /// Presents a vector over T-cells as a vector over cells of type int8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<sbyte> v8i<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsSByte();

        /// <summary>
        /// Presents a vector over T-cells as a vector over cells of type int8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<sbyte> v8i<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsSByte();
    }
}