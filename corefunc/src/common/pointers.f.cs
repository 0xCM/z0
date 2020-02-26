//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Presents generic reference as a generic pointer
    /// </summary>
    /// <param name="src">The memory reference</param>
    /// <typeparam name="T">The reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe T* ptr<T>(ref T src)
        where T : unmanaged
            => refs.ptr(ref src);

    /// <summary>
    /// Presents generic reference as a generic pointer displaced by an element offset
    /// </summary>
    /// <param name="src">The memory reference</param>
    /// <param name="offset">The number of elements to skip</param>
    /// <typeparam name="T">The reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe T* ptr<T>(ref T src, int offset)
        where T : unmanaged
            => refs.ptr(ref src, offset);

    /// <summary>
    /// Presents a readonly reference as a generic pointer which should intself be considered constant
    /// but, as far as the author is aware, no facility within the language can encode that constraint
    /// </summary>
    /// <param name="src">The memory reference</param>
    /// <typeparam name="T">The reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe T* constptr<T>(in T src)
        where T : unmanaged
            => refs.constptr(in src);

    /// <summary>
    /// Presents a readonly reference as a generic pointer displaced by an element offset
    /// </summary>
    /// <param name="src">The memory reference</param>
    /// <param name="offset">The number of elements to skip</param>
    /// <typeparam name="T">The reference type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe T* constptr<T>(in T src, int offset)
        where T : unmanaged
            => refs.constptr(in src, offset);

    /// <summary>
    /// Converts a generic reference into a void pointer
    /// </summary>
    /// <param name="src">The memory reference</param>
    /// <typeparam name="T">The type of the referenced data</typeparam>
    [MethodImpl(Inline)]
    public static unsafe void* pvoid<T>(ref T src)
        => refs.pvoid(ref src);
}