//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;

using Z0;

partial class zfunc
{    
    /// <summary>
    /// Constructs an unpopulated span of a specified length
    /// </summary>
    /// <param name="length">The number of T-sized cells to allocate</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(NotInline)]
    public static Span<T> span<T>(int length)
        => new Span<T>(new T[length]);

    /// <summary>
    /// Constructs a span from an array selection
    /// </summary>
    /// <param name="src">The source array</param>
    /// <param name="offset">The array index where the span is to begin</param>
    /// <param name="length">The number of elements to cover from the aray</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(T[] src, int offset, int length)
        => new Span<T>(src, offset, length);

    /// <summary>
    /// Constructs a span from a parameter array
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(params T[] src)
        => src;

    /// <summary>
    /// Constructs a span from the entireity of a sequence
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(IEnumerable<T> src)
        => src.ToArray();

    /// <summary>
    /// Constructs a span from a sequence selection
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="offset">The number of elements to skip from the head of the sequence</param>
    /// <param name="length">The number of elements to take from the sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(IEnumerable<T> src, int? offset = null, int? length = null)
        => span(length == null ? src.Skip(offset ?? 0) : src.Skip(offset ?? 0).Take(length.Value));

    /// <summary>
    /// Presents a span of bytes as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> gspan<T>(Span<byte> src)
        where T : unmanaged
            => MemoryMarshal.Cast<byte,T>(src);

    /// <summary>
    /// Presents a span of signed bytes as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> gspan<T>(Span<sbyte> src)
        where T : unmanaged
            => MemoryMarshal.Cast<sbyte,T>(src);

    /// <summary>
    /// Presents a span of signed 16-bit unsigned integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> gspan<T>(Span<short> src)
        where T : unmanaged
            => MemoryMarshal.Cast<short,T>(src);

    /// <summary>
    /// Presents a span of unsigned 16-bit unsigned integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> gspan<T>(Span<ushort> src)
        where T : unmanaged
            => MemoryMarshal.Cast<ushort,T>(src);

    /// <summary>
    /// Presents a span of unsigned 32-bit signed integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> gspan<T>(Span<int> src)
        where T : unmanaged
            => MemoryMarshal.Cast<int,T>(src);

    /// <summary>
    /// Presents a span of unsigned 32-bit unsigned integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> gspan<T>(Span<uint> src)
        where T : unmanaged
            => MemoryMarshal.Cast<uint,T>(src);

    /// <summary>
    /// Presents a span of unsigned 64-bit signed integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> gspan<T>(Span<long> src)
        where T : unmanaged
            => MemoryMarshal.Cast<long,T>(src);

    /// <summary>
    /// Presents a span of unsigned 64-bit unsigned integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> gspan<T>(Span<ulong> src)
        where T : unmanaged
            => MemoryMarshal.Cast<ulong,T>(src);

    /// <summary>
    /// Presents a span of unsigned 64-bit floats as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> gspan<T>(Span<double> src)
        where T : unmanaged
            => MemoryMarshal.Cast<double,T>(src);

    /// <summary>
    /// Presents a span of unsigned 32-bit floats as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> gspan<T>(Span<float> src)
        where T : unmanaged
            => MemoryMarshal.Cast<float,T>(src);

    /// <summary>
    /// Presents a span of one cell-type as a span of another cell-type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source span element type</typeparam>
    /// <typeparam name="T">The target span element type</typeparam>
    [MethodImpl(Inline)]        
    public static Span<T> gspan<S,T>(Span<S> src)
        where S : unmanaged
        where T : unmanaged
            => MemoryMarshal.Cast<S,T>(src);                                    

    /// <summary>
    /// Presents a span of signed bytes as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> gspan<T>(ReadOnlySpan<sbyte> src)
        where T : unmanaged
            => MemoryMarshal.Cast<sbyte,T>(src);

    /// <summary>
    /// Presents a span of bytes as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> gspan<T>(ReadOnlySpan<byte> src)
        where T : unmanaged
            => MemoryMarshal.Cast<byte,T>(src);

    /// <summary>
    /// Presents a span of signed 16-bit unsigned integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> gspan<T>(ReadOnlySpan<short> src)
        where T : unmanaged
            => MemoryMarshal.Cast<short,T>(src);

    /// <summary>
    /// Presents a span of unsigned 16-bit unsigned integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> gspan<T>(ReadOnlySpan<ushort> src)
        where T : unmanaged
            => MemoryMarshal.Cast<ushort,T>(src);

    /// <summary>
    /// Presents a span of unsigned 32-bit unsigned integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> gspan<T>(ReadOnlySpan<uint> src)
        where T : unmanaged
            => MemoryMarshal.Cast<uint,T>(src);

    /// <summary>
    /// Presents a span of unsigned 32-bit signed integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> gspan<T>(ReadOnlySpan<int> src)
        where T : unmanaged
            => MemoryMarshal.Cast<int,T>(src);

    /// <summary>
    /// Presents a span of unsigned 64-bit signed integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> gspan<T>(ReadOnlySpan<long> src)
        where T : unmanaged
            => MemoryMarshal.Cast<long,T>(src);

    /// <summary>
    /// Presents a span of unsigned 64-bit unsigned integers as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> gspan<T>(ReadOnlySpan<ulong> src)
        where T : unmanaged
            => MemoryMarshal.Cast<ulong,T>(src);

    /// <summary>
    /// Presents a span of unsigned 32-bit floats as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> gspan<T>(ReadOnlySpan<float> src)
        where T : unmanaged
            => MemoryMarshal.Cast<float,T>(src);

    /// <summary>
    /// Presents a span of unsigned 64-bit floats as a span of generic cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> gspan<T>(ReadOnlySpan<double> src)
        where T : unmanaged
            => MemoryMarshal.Cast<double,T>(src);

    /// <summary>
    /// Presents a readonly span of one cell-type as a span of another cell-type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source span element type</typeparam>
    /// <typeparam name="T">The target span element type</typeparam>
    [MethodImpl(Inline)]        
    public static ReadOnlySpan<T> gspan<S,T>(ReadOnlySpan<S> src)
        where S : unmanaged
        where T : unmanaged
            => MemoryMarshal.Cast<S,T>(src);                                    


}
