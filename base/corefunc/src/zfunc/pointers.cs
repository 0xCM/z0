//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;

using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]
    public static IntPtr intptr(long i)
        => new IntPtr(i);

    /// <summary>
    /// Presents generic reference as a generic pointer
    /// </summary>
    /// <param name="src">The memory reference</param>
    /// <typeparam name="T">The reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe T* ptr<T>(ref T src)
        where T : unmanaged
            => (T*)pvoid(ref src);

    /// <summary>
    /// Presents generic reference as a generic pointer displaced by an element offset
    /// </summary>
    /// <param name="src">The memory reference</param>
    /// <param name="offset">The number of elements to skip</param>
    /// <typeparam name="T">The reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe T* ptr<T>(ref T src, int offset)
        where T : unmanaged
            => (T*)Unsafe.AsPointer(ref seek(ref src, offset));

    /// <summary>
    /// Presents a readonly reference as a generic pointer
    /// </summary>
    /// <param name="src">The memory reference</param>
    /// <typeparam name="T">The reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe T* constptr<T>(in T src)
        where T : unmanaged
            => ptr(ref mutable(in src));

    /// <summary>
    /// Presents a readonly reference as a generic pointer displaced by an element offset
    /// </summary>
    /// <param name="src">The memory reference</param>
    /// <param name="offset">The number of elements to skip</param>
    /// <typeparam name="T">The reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe T* constptr<T>(in T src, int offset)
        where T : unmanaged
            => ptr(ref mutable(in skip(in src, offset)));

    /// <summary>
    /// Converts a generic reference into a void pointer
    /// </summary>
    /// <param name="src">The memory reference</param>
    /// <typeparam name="T">The type of the referenced data</typeparam>
    [MethodImpl(Inline)]
    public static unsafe void* pvoid<T>(ref T src)
        => Unsafe.AsPointer(ref src);

    /// <summary>
    /// Presents a generic reference r:T as a generic pointer p:T
    /// </summary>
    /// <param name="r">The memory reference</param>
    /// <typeparam name="T">The source reference type</typeparam>
    /// <typeparam name="P">The target pointer type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe P* ptr<T,P>(ref T r)
        where T : unmanaged
        where P : unmanaged
            => (P*)Unsafe.AsPointer(ref r);

    /// <summary>
    /// Presents a generic reference as a byte pointer
    /// </summary>
    /// <param name="r">The memory reference</param>
    /// <typeparam name="T">The source reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe byte* pbyte<T>(ref T r)
        where T : unmanaged
            =>ptr<T,byte>(ref r);

    /// <summary>
    /// Presents a generic reference as a short pointer
    /// </summary>
    /// <param name="r">The memory reference</param>
    /// <typeparam name="T">The source reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe short* pshort<T>(ref T r)
        where T : unmanaged
            => ptr<T,short>(ref r);

    /// <summary>
    /// Presents a generic reference as an int pointer
    /// </summary>
    /// <param name="r">The memory reference</param>
    /// <typeparam name="T">The source reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe int* pint<T>(ref T r)
        where T : unmanaged
            => ptr<T,int>(ref r);

    /// <summary>
    /// Presents a generic reference as a long pointer
    /// </summary>
    /// <param name="r">The memory reference</param>
    /// <typeparam name="T">The source reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe long* plong<T>(ref T r)
        where T : unmanaged
            => ptr<T,long>(ref r);

    /// <summary>
    /// Presents a generic reference as an unsigned long pointer
    /// </summary>
    /// <param name="r">The memory reference</param>
    /// <typeparam name="T">The source reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe ulong* plongu<T>(ref T r)
        where T : unmanaged
            => ptr<T,ulong>(ref r);
}