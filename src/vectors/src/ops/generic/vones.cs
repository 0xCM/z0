//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    partial class Vectors
    {
        /// <summary>
        /// Creates a 128-bit vector with all bits enabled
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector128<T> vones<T>(N128 n, T t = default)
            where T : unmanaged
                => Vectors.veq(default(Vector128<T>), default(Vector128<T>));

        /// <summary>
        /// Creates a 256-bit vector with all bits enabled
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector256<T> vones<T>(N256 n, T t = default)
            where T : unmanaged
                => Vectors.veq(default(Vector256<T>), default(Vector256<T>));

        /// <summary>
        /// Creates a 512-bit vector with all bits enabled
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector512<T> vones<T>(N512 n, T t = default)
            where T : unmanaged
                => Vectors.veq(default(Vector512<T>), default(Vector512<T>));

    }
}