//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
    /// Allocates a span
    /// </summary>
    /// <param name="length">The number cells to allocate</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(NotInline)]
    public static Span<T> alloc<T>(int length, T t = default)
        => Spans.alloc<T>(length);

    /// <summary>
    /// Allocates a span
    /// </summary>
    /// <param name="length">The number cells to allocate</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(NotInline)]
    public static Span<T> alloc<T>(ushort length, T t = default)
        => Spans.alloc<T>(length);

    /// <summary>
    /// Allocates a span
    /// </summary>
    /// <param name="length">The number cells to allocate</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(NotInline)]
    public static Span<T> alloc<T>(byte length, T t = default)
        => Spans.alloc<T>(length);

    [MethodImpl(Inline)]
    public static unsafe Span<T> span<T>(T* pSrc, int length)
        where T : unmanaged
            => Spans.cover(pSrc,length);
}