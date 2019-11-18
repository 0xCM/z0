//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

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
        => ref Unsafe.AsRef(in src);

    /// <summary>
    /// Presents a reference as a byte reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref byte byterefR<T>(ref T src)
        where T : unmanaged
            => ref Unsafe.As<T,byte>(ref src);

    /// <summary>
    /// Presents a readonly reference as a byte reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref byte byteref<T>(in T src)
        where T :unmanaged
            => ref Unsafe.As<T,byte>(ref mutable(in src));

    /// <summary>
    /// The canonical swap function
    /// </summary>
    /// <param name="lhs">The left value</param>
    /// <param name="rhs">The right value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static void swap<T>(ref T lhs, ref T rhs)
    {
        var temp = lhs;
        lhs = rhs;
        rhs = temp;
    }

    /// <summary>
    /// Adds an offset to a reference, measured relative to the reference type
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="bytes">The number of elements to advance</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seek<T>(ref T src, int count)
        where T : unmanaged
            => ref Unsafe.Add(ref src, count);

    /// <summary>
    /// Adds an offset to the head of a span, measured relative to the reference type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="bytes">The number of elements to advance</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seek<T>(Span<T> src, int count)
        where T : unmanaged
            => ref seek(ref head(src), count);

    /// <summary>
    /// Adds an offset to a reference, measured in bytes
    /// </summary>
    /// <param name="src">The soruce reference</param>
    /// <param name="count">The number of bytes to add</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seekb<T>(ref T src, long count)
        where T : unmanaged
            => ref Unsafe.AddByteOffset(ref src, intptr(count));

    /// <summary>
    /// Adds an offset to the head of a span, measured in bytes
    /// </summary>
    /// <param name="src">The soruce reference</param>
    /// <param name="count">The number of bytes to add</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seekb<T>(Span<T> src, long count)
        where T : unmanaged
            => ref seekb(ref head(src), count);

    /// <summary>
    /// Returns an readonly reference to a memory location following a specified number of elements
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="count">The number of elements to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skip<T>(in T src, int count)
        where T : unmanaged
            => ref Unsafe.Add(ref mutable(in src), count);

    /// <summary>
    /// Returns an readonly reference to a memory location following a specified number of elements
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="count">The number of elements to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
        where T : unmanaged
            => ref skip(in head(src), count);

    /// <summary>
    /// Returns an readonly reference to a memory location, following a specified number of bytes
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="count">The number of elements to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skipb<T>(in T src, long count)
        where T : unmanaged
            => ref Unsafe.Add(ref mutable(in src), intptr(count));

    /// <summary>
    /// Returns an readonly reference to a memory location, following a specified number of bytes
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="count">The number of elements to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skipb<T>(ReadOnlySpan<T> src, long count)
        where T : unmanaged
            => ref skipb(in head(src), count);    
}