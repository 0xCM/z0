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

    partial class Fixed    
    {
        /// <summary>
        /// Initializes a 128-bit value with a 128-bit source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Fixed128 vfix<T>(Vector128<T> x)
            where T : unmanaged
                => new Fixed128(v64u(x));

        /// <summary>
        /// Initializes a 256-bit value with a 256-bit source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Fixed256 vfix<T>(Vector256<T> x)
            where T : unmanaged
                => new Fixed256(v64u(x));
    }
}