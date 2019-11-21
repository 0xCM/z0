//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Returns a reference to the location of the first element
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe ref T head<T>(T[] src)
        where T : unmanaged
            => ref src[0];
    
    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span<T> src)
        =>  ref MemoryMarshal.GetReference<T>(src);


    /// <summary>
    /// Returns a reference to the head of a span, offset by a specified amount
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span<T> src, int offset)
        => ref Unsafe.Add(ref head(src), offset);        


    /// <summary>
    /// Returns a reference to the head of a readonly span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T head<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            =>  ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Returns a readonly reference to the head of a readonly span, offset by a specified amount
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T head<T>(ReadOnlySpan<T> src, int offset)
        where T : unmanaged
            =>  ref Unsafe.Add(ref MemoryMarshal.GetReference<T>(src), offset);

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<N,T>(in NatBlock<N,T> src)
        where N : unmanaged, ITypeNat
        where T : unmanaged
            =>  ref src.Head;

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T head<N,T>(in ConstNatBlock<N,T> src)
        where N : unmanaged, ITypeNat
        where T : unmanaged
            => ref src.Head;

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(in Block128<T> src)
        where T : unmanaged
            => ref src.Head;

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(in Block256<T> src)
        where T : unmanaged
            => ref src.Head;

    /// <summary>
    /// Returns a readonly reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T head<T>(in ConstBlock128<T> src)
        where T : unmanaged
            =>  ref src.Head;

    /// <summary>
    /// Returns a readonly reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T head<T>(in ConstBlock256<T> src)
        where T : unmanaged
            =>  ref src.Head;

    /// <summary>
    /// Presents the span head as a reference to an unsigned 16-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref ushort head16(Span<byte> src)
        => ref head(src.AsUInt16());

    /// <summary>
    /// Presents the span head as a reference to an unsigned 16-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ushort head16(ReadOnlySpan<byte> src)
        => ref head(src.AsUInt16());

    /// <summary>
    /// Presents the bytespan head as a reference to an unsigned 32-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref uint head32(Span<byte> src)
        => ref head(src.AsUInt32());

    /// <summary>
    /// Presents the span head as a reference to an unsigned 32-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly uint head32(ReadOnlySpan<byte> src)
        => ref head(src.AsUInt32());

    /// <summary>
    /// Presents the span head as a reference to an unsigned 32-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref uint head32(Span<ushort> src)
        => ref head(src.AsUInt32());

    /// <summary>
    /// Presents the span head as a reference to an unsigned 32-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly uint head32(ReadOnlySpan<ushort> src)
        => ref head(src.AsUInt32());

    /// <summary>
    /// Presents the span head as a reference to an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref ulong head64(Span<byte> src)
        => ref head(src.AsUInt64());

    /// <summary>
    /// Presents the span head as a reference to an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ulong head64(ReadOnlySpan<byte> src)
        => ref head(src.AsUInt64());

    /// <summary>
    /// Presents the span head as a reference to an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref ulong head64(Span<ushort> src)
        => ref head(src.AsUInt64());

    /// <summary>
    /// Presents the span head as a reference to an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ulong head64(ReadOnlySpan<ushort> src)
        => ref head(src.AsUInt64());

    /// <summary>
    /// Presents the span head as a reference to an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref ulong head64(Span<uint> src)
        => ref head(src.AsUInt64());

    /// <summary>
    /// Presents the span head as a reference to an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ulong head64(ReadOnlySpan<uint> src)
        => ref head(src.AsUInt64());

    /// <summary>
    /// Returns a reference to the location of a non-leading span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(in Block128<T> src, int offset)
        where T : unmanaged
            => ref Unsafe.Add(ref src.Head, offset);        

    /// <summary>
    /// Returns a reference to the location of a non-leading span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(in Block256<T> src, int offset)
        where T : unmanaged
            => ref Unsafe.Add(ref src.Head, offset);        



}