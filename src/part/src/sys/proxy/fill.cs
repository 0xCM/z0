//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static OpacityApiClass;

    partial struct proxy
    {
        [MethodImpl(Options), Opaque(FormatCharSpan)]
        public static string format(ReadOnlySpan<char> src)
            => src.ToString();

        [MethodImpl(Options), Opaque(FillSpan), Closures(Closure)]
        public static void fill<T>(T src, Span<T> dst)
            => dst.Fill(src);

        [MethodImpl(Options), Opaque(InitRefBlock)]
        public static ref byte fill(byte src, ref byte dst, uint length)
        {
            InitBlock(ref dst, src, length);
            return ref dst;
        }

        /// <summary>
        /// Fills an array, in-place, with a specified value
        /// </summary>
        /// <param name="dst">The target array</param>
        /// <param name="dst">The source value</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Options), Opaque(FillArray), Closures(Closure)]
        public static T[] fill<T>(T[] dst, T src)
        {
            Array.Fill(dst, src);
            return dst;
        }
    }
}