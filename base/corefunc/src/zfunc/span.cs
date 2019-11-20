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
    /// Copies data from a readonly memory reference of one type to a memory refrence to another type
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="dst">The target reference</param>
    /// <param name="targets">The number of target values to populate</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe void memcpy<S,T>(in S src, ref T dst, uint targets)
        where T : unmanaged
        where S : unmanaged
            =>  Unsafe.CopyBlock(ptr(ref dst), Unsafe.AsPointer(ref Unsafe.AsRef(in src)), targets*size<T>());

    /// <summary>
    /// Copies a contiguous segments of bytes from one location to another
    /// </summary>
    /// <param name="pSrc">The location of the source bytes</param>
    /// <param name="pDst">The location of the target</param>
    /// <param name="targets">The number of values to copy</param>
    [MethodImpl(Inline)]
    public static unsafe void memcpy(byte* pSrc, byte* pDst, uint targets)
        => Unsafe.CopyBlock(pDst, pSrc, targets);

    /// <summary>
    /// Copies a contiguous segments of values from one location to another
    /// </summary>
    /// <param name="pSrc">The location of the source bytes</param>
    /// <param name="pDst">The location of the target</param>
    /// <param name="targets">The number of values to copy</param>
    [MethodImpl(Inline)]
    public static unsafe void memcpy<T>(T* pSrc, T* pDst, uint targets)
        where T : unmanaged
            => Unsafe.CopyBlock(pDst, pSrc, (uint)(size<T>()*targets));

    /// <summary>
    /// Copies a contiguous segments of values to a span
    /// </summary>
    /// <param name="pSrc">The location of the source bytes</param>
    /// <param name="pDst">The location of the target</param>
    /// <param name="targets">The number of values to copy</param>
    [MethodImpl(Inline)]
    public static unsafe void memcpy<T>(T* pSrc, Span<T> dst, int offset, uint targets)
        where T : unmanaged
            =>  memcpy(pSrc, ptr(ref head(dst), offset), targets); 

    /// <summary>
    /// Copies a contiguous segments of bytes from a source location to a target span
    /// </summary>
    /// <param name="pSrc">The location of the source bytes</param>
    /// <param name="dst">The location of the target</param>
    /// <param name="targets">The number of values to copy</param>
    [MethodImpl(Inline)]
    public static unsafe void memcpy(byte* pSrc, Span<byte> dst, int offset, uint targets)
        => memcpy(pSrc, (byte*)Unsafe.AsPointer(ref seek(dst, offset)) , targets);

    /// <summary>
    /// Populates a target span from a source span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="dst">The target span</param>
    /// <param name="targets">The count of target values to populate</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe void memcpy<S,T>(ReadOnlySpan<S> src, Span<T> dst, uint targets)
        where T : unmanaged
        where S : unmanaged
            => memcpy(in head(src), ref head(dst), targets);

    /// <summary>
    /// Populates a target array from a source array
    /// </summary>
    /// <param name="src">The source array</param>
    /// <param name="dst">The target array</param>
    /// <param name="targets">The count of target values to populate</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe bool memcpy<S,T>(S[] src, T[] dst)
        where T : unmanaged
        where S : unmanaged
    {
        
        var srcLen = (uint)(size<S>() * src.Length);
        var dstLen = (uint)(size<T>() * dst.Length);
        if(srcLen != dstLen)
            return false;

        memcpy(in head(src), ref head(dst), (uint)dst.Length);
        return true;
    }

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

    /// <summary>
    /// Copies data from an unmanaged value to a target span
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target cell type</typeparam>
    [MethodImpl(Inline)]   
    public static void copy<S,T>(ref S src, Span<T> dst)
        where T : unmanaged
    {
        ref var dstBytes = ref Unsafe.As<T, byte>(ref head(dst));
        Unsafe.WriteUnaligned<S>(ref dstBytes, src);
    }

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
        => new Span<T>(src,offset, length);


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

    /// <summary>
    /// Constructs a span from a parameter array
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(params T[] src)
        => src;

    /// <summary>
    /// Loads a span from a memory reference
    /// </summary>
    /// <param name="src">The memory source</param>
    /// <param name="length">The memory length relative to the cell type</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<T> span<T>(ref T src, int length)
        => MemoryMarshal.CreateSpan(ref src, length);

    /// <summary>
    /// Constructs a span from the entireity of a sequence
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(IEnumerable<T> src)
        => src.ToSpan();

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
    /// Presents a source reference as a span of bytes
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<byte> bytespan<T>(ref T src)
        where T : unmanaged
            => MemoryMarshal.CreateSpan(ref byterefR(ref src), size<T>()); 

    /// <summary>
    /// Converts the source span to a readonly bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<byte> bytespan<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            => MemoryMarshal.AsBytes(src);

    /// <summary>
    /// Converts the source span to a bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> bytes<T>(Span<T> src)
        where T : unmanaged
            => MemoryMarshal.AsBytes(src);

    /// <summary>
    /// Converts a source value of any value type to its bytespan representation
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static void bytes<T>(in T src, Span<byte> dst)
        where T : unmanaged
            => As.generic<T>(ref head(dst)) = src;

    /// <summary>
    /// Converts the source value to a bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> bytes<T>(in T src)
        where T : unmanaged
            => MemoryMarshal.AsBytes(span(src));

}
