//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Reimagines a span of one element type as a span of another element type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    internal static Span<T> cast<S,T>(in Span<S> src)                
        where S : unmanaged
        where T : unmanaged
            => MemoryMarshal.Cast<S,T>(src);

    /// <summary>
    /// Reimagines a span of one element type as a span of another element type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    internal static ReadOnlySpan<T> cast<S,T>(in ReadOnlySpan<S> src)                
        where S : unmanaged
        where T : unmanaged
            => MemoryMarshal.Cast<S,T>(src);

    /// <summary>
    /// Presents a blocked span of S-cells as a blocked span of T-cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    internal static Block64<T> cast<S,T>(in Block64<S> src)                
        where S : unmanaged
        where T : unmanaged
            => src.As<T>();

    /// <summary>
    /// Reimagines a readonly span of one element type as a readonly span of another element type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    internal static ConstBlock64<T> cast<S,T>(in ConstBlock64<S> src)                
        where S : unmanaged
        where T : unmanaged
            => src.As<T>();

    /// <summary>
    /// Presents a blocked span of S-cells as a blocked span of T-cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    internal static Block128<T> cast<S,T>(in Block128<S> src)                
        where S : unmanaged
        where T : unmanaged
            => src.As<T>();

    /// <summary>
    /// Presents a readonly blocked span of S-cells as a readonly blocked span of T-cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    internal static ConstBlock128<T> cast<S,T>(in ConstBlock128<S> src)                
        where S : unmanaged
        where T : unmanaged
            => src.As<T>();

    /// <summary>
    /// Presents a blocked span of S-cells as a blocked span of T-cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    internal static Block256<T> cast<S,T>(in Block256<S> src)                
        where S : unmanaged
        where T : unmanaged
            => src.As<T>();

    /// <summary>
    /// Presents a readonly blocked span of S-cells as a readonly blocked span of T-cells
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    internal static ConstBlock256<T> cast<S,T>(in ConstBlock256<S> src)                
        where S : unmanaged
        where T : unmanaged
            => src.As<T>();               

    [MethodImpl(Inline)]   
    public static ref T cast<S,T>(ref S src)
        => ref Unsafe.As<S,T>(ref src);

    /// <summary>
    /// Reinterprents a source value through the perpective of another type
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static ref T cast<S,T>(ref S src, out T dst)
    {
        dst = Unsafe.As<S,T>(ref src);
        return ref dst;
    }

    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
        where S : unmanaged
        where T : unmanaged
            => MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src, out ReadOnlySpan<T> dst)                
        where S : unmanaged
        where T : unmanaged
            => dst = MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static Span<T> cast<S,T>(Span<S> src)                
        where S : unmanaged
        where T : unmanaged
            => MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static Span<T> cast<S,T>(Span<S> src, out Span<T> dst)                
        where S : unmanaged
        where T : unmanaged
            => dst = MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src, int offset, int length)
        where T : unmanaged
            => MemoryMarshal.Cast<byte,T>(src.Slice(offset, length * Unsafe.SizeOf<T>()));

    [MethodImpl(Inline)]
    public static Span<T> cast<T>(Span<byte> src, int offset, int length)
        where T : unmanaged
            => MemoryMarshal.Cast<byte,T>(src.Slice(offset, length * Unsafe.SizeOf<T>()));
    
    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
        where T : unmanaged
            => cast<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

    [MethodImpl(Inline)]
    public static Span<T> cast<T>(Span<byte> src)
        where T : unmanaged        
            => cast<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

    [MethodImpl(Inline)]
    public static Span<T> cast<T>(Span<byte> src, out Span<byte> rem)
        where T : unmanaged        
    {
        rem = Span<byte>.Empty;
        var tSize = Unsafe.SizeOf<T>();
        var dst = cast<T>(src);
        var q = Math.DivRem(dst.Length, tSize, out int r);
        if(r != 0)
            rem = src.Slice(dst.Length*tSize);
        return dst;
    }

}