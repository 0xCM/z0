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

    partial struct AsDeprecated
    {
        /// <summary>
        /// Skips a specified number of 16-bit source segments and returns a reference to the located cell
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 16-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort skip16<T>(in T src, int count)
            => ref Add(ref edit<T,ushort>(src), count);

        /// <summary>
        /// Skips a specified number of 32-bit source segments and returns a reference to the located cell
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint skip32<T>(in T src, uint count)
            => ref Add(ref edit<T,uint>(src), (int)count);

        /// <summary>
        /// Skips a specified number of 54-bit source segments and returns a reference to the located cell
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong skip64<T>(in T src, uint count)
            => ref Add(ref edit<T,ulong>(src), (int)count);
    }
}