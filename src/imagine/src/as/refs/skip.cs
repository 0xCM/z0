//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct As
    {
        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte skip8<T>(in T src, int count)
            => ref As.skipw(default(W8), src, count);

        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte skipw<T>(W8 w, in T src, int count)
            => ref Add(ref As<T,byte>(ref edit(in src)), count);
    }
}