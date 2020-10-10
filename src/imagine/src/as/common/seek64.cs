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
        /// Adds an offset, measured by 32-bit segments, to a source reference and presents the cell
        /// at the offset as an unsigned integer of bit-width <see cref='W64'/>
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline)]
        public static ref ulong seek64<T>(in T src, uint count)
            => ref Add(ref As<T,ulong>(ref edit(src)), (int)count);

        /// <summary>
        /// Adds a specified offset count, measured by 64-bit segments, to the leading cell of a source span
        /// and returns the offset cell as an unsigned integer of bit-width <see cref='W64'/>
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong seek64<T>(Span<T> src, uint count)
            => ref Add(ref As<T,ulong>(ref first(src)), (int)count);
    }
}