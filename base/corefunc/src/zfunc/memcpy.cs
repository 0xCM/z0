//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    

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

    /// <summary>
    /// Copies data from an unmanaged value to a target span
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target cell type</typeparam>
    [MethodImpl(Inline)]   
    public static void memcpy<S,T>(ref S src, Span<T> dst)
        where T : unmanaged
    {
        ref var dstBytes = ref Unsafe.As<T, byte>(ref head(dst));
        Unsafe.WriteUnaligned<S>(ref dstBytes, src);
    }
}