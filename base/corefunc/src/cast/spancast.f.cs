//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;

using Z0;

partial class zfunc
{    
    /// <summary>
    /// Presents a span of generic values as a span of bytes
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> bytes<T>(Span<T> src)
        where T : unmanaged
            => MemoryMarshal.AsBytes(src);

    /// <summary>
    /// Loads a bytespan of natural length from a generic source span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static NatSpan<N,byte> bytes<N,T>(Span<T> src, N n = default)
        where T : unmanaged
        where N : unmanaged, ITypeNat
            => NatSpan.load(MemoryMarshal.AsBytes(src),n);

    /// <summary>
    /// Presents a span of generic values as a span of bytes
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> span8u<T>(Span<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    /// <summary>
    /// Presents a readonly span of generic values as a span of signed bytes
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<sbyte> span8i<T>(Span<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);

    /// <summary>
    /// Presents a span of generic values as a span of signed 16-bit integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<short> span16i<T>(Span<T> src)
        where T : unmanaged        
            => cast<T,short>(src);

    /// <summary>
    /// Presents a span of generic values as a span of unsigned 16-bit integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<ushort> span16u<T>(Span<T> src)
        where T : unmanaged        
            => cast<T,ushort>(src);

    /// <summary>
    /// Presents a span of generic values as a span of signed 32-bit integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<int> span32i<T>(Span<T> src)
        where T : unmanaged        
            => cast<T,int>(src);

    /// <summary>
    /// Presents a span of generic values as a span of unsigned 32-bit integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<uint> span32u<T>(Span<T> src)
        where T : unmanaged        
            => cast<T,uint>(src);

    /// <summary>
    /// Presents a span of generic values as a span of 64-bit signed integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<long> span64i<T>(Span<T> src)
        where T : unmanaged        
            => cast<T,long>(src);

    /// <summary>
    /// Presents a span of generic values as a span of 64-bit unsigned integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<ulong> span64u<T>(Span<T> src)
        where T : unmanaged        
            => cast<T,ulong>(src);

    /// <summary>
    /// Presents a span of generic values as a span of 32-bit floats
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<float> span32f<T>(Span<T> src)
        where T : unmanaged        
            => cast<T,float>(src);

    /// <summary>
    /// Presents a span of generic values as a span of 64-bit floats
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<double> span64f<T>(Span<T> src)
        where T : unmanaged        
            => cast<T,double>(src);

    /// <summary>
    /// Presents a readonly span ofgeneric values as a readonly span of signed bytes
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<sbyte> span8i<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);

    /// <summary>
    /// Presents a readonly span ofgeneric values as a readonly span of bytes
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<byte> span8u<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            => MemoryMarshal.AsBytes(src);

    /// <summary>
    /// Presents a readonly span of generic values as a readonly span of signed 16-bit integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<short> span16i<T>(ReadOnlySpan<T> src)
        where T : unmanaged        
            => cast<T,short>(src);

    /// <summary>
    /// Presents a readonly span of generic values as a readonly span of unsigned 16-bit integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<ushort> span16u<T>(ReadOnlySpan<T> src)
        where T : unmanaged        
            => cast<T,ushort>(src);

    /// <summary>
    /// Presents a readonly span of generic values as a readonly span of signed 32-bit integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<int> span32i<T>(ReadOnlySpan<T> src)
        where T : unmanaged        
            => cast<T,int>(src);

    /// <summary>
    /// Presents a readonly span of generic values as a readonly span of unsigned 32-bit integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<uint> span32u<T>(ReadOnlySpan<T> src)
        where T : unmanaged        
            => cast<T,uint>(src);

    /// <summary>
    /// Presents a readonly span of generic values as a readonly span of 64-bit signed integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<long> span64i<T>(ReadOnlySpan<T> src)
        where T : unmanaged        
            => cast<T,long>(src);

    /// <summary>
    /// Presents a readonly span of generic values as a readonly span of 64-bit unsigned integers
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<ulong> span64u<T>(ReadOnlySpan<T> src)
        where T : unmanaged        
            => cast<T,ulong>(src);

    /// <summary>
    /// Presents a readonly span of generic values as a readonly span of 32-bit floats
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<float> span32f<T>(ReadOnlySpan<T> src)
        where T : unmanaged        
            => cast<T,float>(src);

    /// <summary>
    /// Presents a readonly readonly span of generic values as a readonly readonly span of 64-bit floats
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<double> span64f<T>(ReadOnlySpan<T> src)
        where T : unmanaged        
            => cast<T,double>(src);
}