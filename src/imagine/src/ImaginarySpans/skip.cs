//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Eliminates trailing zeros in the source span
        /// </summary>
        /// <param name="src">The source span</param>
        public static Span<byte> TrimEnd(this Span<byte> src)
        {
            var length = src.Length;
            for(var i= length - 1; i>=0; i--)
            {
                ref readonly var x = ref Imagine.skip(src,i);
                if(x != 0)
                    return Imagine.slice(src, 0,length);
            }
            return Span<byte>.Empty;
        }
    }

    readonly partial struct Imagine
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, byte count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(Span<T> src, byte count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(Span<T> src, int count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(Span<T> src, int count)
            => ref add(first(src), count);
    }
}