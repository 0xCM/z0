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

    using static System.Runtime.CompilerServices.Unsafe;
    using static Root;

    partial struct core
    {
        /// <summary>
        /// Computes the bit-width of a parametrically-identified type
        /// </summary>
        /// <param name="w">The result width selector</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte width<T>(W8 w)
            => (byte)(SizeOf<T>() * 8);

        /// <summary>
        /// Computes the bit-width of a parametrically-identified type
        /// </summary>
        /// <param name="w">The result width selector</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort width<T>(W16 w)
            => (ushort)(SizeOf<T>() * 8);

        /// <summary>
        /// Computes the bit-width of a parametrically-identified type
        /// </summary>
        /// <param name="w">The result width selector</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint width<T>(W32 w)
            => (uint)(SizeOf<T>() * 8);

        /// <summary>
        /// Computes the bit-width of a parametrically-identified type
        /// </summary>
        /// <param name="w">The result width selector</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong width<T>(W64 w)
            => (ulong)(SizeOf<T>() * 8);
    }
}