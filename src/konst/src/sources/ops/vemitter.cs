//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Sources
    {
        /// <summary>
        /// Creates a 128-bit vectorized emitter predicated an a specified source
        /// </summary>
        /// <param name="w">The vector bit width</param>
        /// <param name="src">The data source</param>
        /// <param name="t">A vector component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VEmitter128<T> vemitter<T>(N128 w, ISource src)
            where T : unmanaged
                => new VEmitter128<T>(src);

        /// <summary>
        /// Creates a 256-bit vectorized emitter predicated an a specified source
        /// </summary>
        /// <param name="w">The vector bit width</param>
        /// <param name="src">The data source</param>
        /// <param name="t">A vector component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VEmitter256<T> vemitter<T>(N256 w, ISource src)
            where T : unmanaged
                => new VEmitter256<T>(src);

        /// <summary>
        /// Creates a 256-bit vectorized emitter predicated an a specified source
        /// </summary>
        /// <param name="w">The vector bit width</param>
        /// <param name="src">The data source</param>
        /// <param name="t">A vector component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VEmitter512<T> vemitter<T>(N512 w, ISource src)
            where T : unmanaged
                => new VEmitter512<T>(src);
    }
}