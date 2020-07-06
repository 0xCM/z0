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

    partial struct V0
    {           
        /// <summary>
        /// Computes the vector component count for a given bit-width and component type
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int vcount<T>(W128 w, T t = default)
            where T : unmanaged
                => Vector128<T>.Count;

        /// <summary>
        /// Computes the vector component count for a given bit-width and component type
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int vcount<T>(W256 w, T t = default)
            where T : unmanaged
                => Vector256<T>.Count;

        /// <summary>
        /// Computes the vector component count for a given bit-width and component type
        /// </summary>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int vcount<T>(W512 w, T t = default)
            where T : unmanaged
                => Vector512<T>.Count;        
    }
}