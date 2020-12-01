//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct Sources
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates a 128-bit vectorized emitter predicated an a specified random source
        /// </summary>
        /// <param name="w">The vector bit width</param>
        /// <param name="random">The random source</param>
        /// <param name="t">A vector component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static VEmitter128<T> vemitter<T>(N128 w, ISource random)
            where T : unmanaged
                => new VEmitter128<T>(random);

        /// <summary>
        /// Creates a 256-bit vectorized emitter predicated an a specified random source
        /// </summary>
        /// <param name="w">The vector bit width</param>
        /// <param name="random">The random source</param>
        /// <param name="t">A vector component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static VEmitter256<T> vemitter<T>(N256 w, ISource random)
            where T : unmanaged
                => new VEmitter256<T>(random);
    }

    [ApiHost]
    public static partial class XSource
    {

    }
}
