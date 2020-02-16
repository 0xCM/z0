//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.InteropServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Presents a readonly reference as reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref T mutable<T>(in T src)
        => ref Refs.mutable(src);

    /// <summary>
    /// Presents a reference as a byte reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref byte byterefR<T>(ref T src)
        => ref Refs.byterefR(ref src);

    /// <summary>
    /// Presents a readonly reference as a byte reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref byte byteref<T>(in T src)
        => ref Refs.byteref(in src);

    /// <summary>
    /// The canonical swap function
    /// </summary>
    /// <param name="lhs">The left value</param>
    /// <param name="rhs">The right value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static void swap<T>(ref T lhs, ref T rhs)
        => Refs.swap(ref lhs, ref rhs);

    /// <summary>
    /// Adds an offset to a reference, measured relative to the reference type
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="bytes">The number of elements to advance</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seek<T>(ref T src, int count)
        => ref Refs.seek(ref src, count);

    [MethodImpl(Inline)]
    public static ref byte seek8<T>(ref T src, int count)
        => ref Refs.seek8(ref src, count);

    [MethodImpl(Inline)]
    public static ref ushort seek16<T>(ref T src, int count)
        => ref Refs.seek16(ref src, count);

    [MethodImpl(Inline)]
    public static ref uint seek32<T>(ref T src, int count)
        => ref Refs.seek32(ref src, count);

    [MethodImpl(Inline)]
    public static ref ulong seek64<T>(ref T src, int count)
        => ref Refs.seek64(ref src, count);

    /// <summary>
    /// Adds an offset to the head of a span, measured relative to 8-bit segments, and returns the resulting reference
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 8-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref byte seek8<T>(Span<T> src, int count)
        => ref SpanOps.seek8(src, count);

    /// <summary>
    /// Adds an offset to the head of a span, measured relative to 16-bit segments, and returns the resulting reference
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 16-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref ushort seek16<T>(Span<T> src, int count)
        => ref SpanOps.seek16(src, count);

    /// <summary>
    /// Adds an offset to the head of a span, measured relative to 32-bit segments, and returns the resulting reference
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 32-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref uint seek32<T>(Span<T> src, int count)
        => ref SpanOps.seek32(src, count);

    /// <summary>
    /// Adds an offset to the head of a span, measured relative to 64-bit segments, and returns the resulting reference
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 64-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref ulong seek64<T>(Span<T> src, int count)
        => ref SpanOps.seek64(src, count);

    /// <summary>
    /// Adds an offset to the head of a span, measured relative to the reference type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="bytes">The number of elements to advance</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seek<T>(Span<T> src, int count)
        => ref SpanOps.seek(src, count);

    /// <summary>
    /// Adds an offset to a reference, measured in bytes
    /// </summary>
    /// <param name="src">The soruce reference</param>
    /// <param name="count">The number of bytes to add</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seekb<T>(ref T src, long count)
        => ref Refs.seekb(ref src, count);

    /// <summary>
    /// Adds an offset to the head of a span, measured in bytes
    /// </summary>
    /// <param name="src">The soruce reference</param>
    /// <param name="count">The number of bytes to add</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seekb<T>(Span<T> src, long count)
        => ref SpanOps.seekb(src, count);

    /// <summary>
    /// Adds an offset to the head of a span, measured relative to the reference type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="bytes">The number of elements to advance</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skip<T>(Span<T> src, int count)
        => ref SpanOps.skip(src,count);

    /// <summary>
    /// Skips a specified number of source elements and returns a readonly reference to the resulting element
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="count">The number of elements to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skip<T>(in T src, int count)
        => ref Refs.skip(src,count);

    /// <summary>
    /// Skips a specified number of 8-bit source segments and returns a readonly reference to the resulting memory location
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 8-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref byte skip8<T>(in T src, int count)
        => ref Refs.skip8(src,count);

    /// <summary>
    /// Skips a specified number of 16-bit source segments and returns a readonly reference to the resulting memory location
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 16-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref ushort skip16<T>(in T src, int count)
        => ref Refs.skip16(src,count);

    /// <summary>
    /// Skips a specified number of 32-bit source segments and returns a readonly reference to the resulting memory location
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 32-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref uint skip32<T>(in T src, int count)
        => ref Refs.skip32(src,count);

    /// <summary>
    /// Skips a specified number of 64-bit source segments and returns a readonly reference to the resulting memory location
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 64-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref ulong skip64<T>(in T src, int count)
        => ref Refs.skip64(src,count);

    /// <summary>
    /// Skips a specified number of 8-bit source segments and returns a readonly reference to the resulting memory location
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 8-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly byte skip8<T>(ReadOnlySpan<T> src, int count)
        => ref SpanOps.skip8(src,count);

    /// <summary>
    /// Skips a specified number of 16-bit source segments and returns a readonly reference to the resulting memory location
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 16-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ushort skip16<T>(ReadOnlySpan<T> src, int count)
        => ref SpanOps.skip16(src,count);

    /// <summary>
    /// Skips a specified number of 32-bit source segments and returns a readonly reference to the resulting memory location
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 32-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly uint skip32<T>(ReadOnlySpan<T> src, int count)
        => ref SpanOps.skip32(src,count);

    /// <summary>
    /// Skips a specified number of 64-bit source segments and returns a readonly reference to the resulting memory location
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of 64-bit segments to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ulong skip64<T>(ReadOnlySpan<T> src, int count)
        => ref SpanOps.skip64(src,count);

    /// <summary>
    /// Skips a specified number of source segments and returns a readonly reference to the leading element following the advance
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of elements to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
        => ref SpanOps.skip(src,count);

    /// <summary>
    /// Returns an readonly reference to a memory location, following a specified number of bytes
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="count">The number of elements to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skipb<T>(in T src, long count)
        => ref Refs.skipb(src,count);

    /// <summary>
    /// Returns an readonly reference to a memory location, following a specified number of bytes
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="count">The number of elements to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skipb<T>(ReadOnlySpan<T> src, long count)
        => ref SpanOps.skipb(src,count);
}