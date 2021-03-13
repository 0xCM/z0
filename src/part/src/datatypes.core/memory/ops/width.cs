//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct memory
    {
        /// <summary>
        /// Computes the bit-width of a parametrically-identified type, returning the result as a <see cref='BitWidth'/> value
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitWidth width<T>()
            => Unsafe.SizeOf<T>()*8;

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