//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]
    public static IntPtr intptr(long i)
        => new IntPtr(i);

    [MethodImpl(Inline)]
    public static IntPtr intptr(int i)
        => new IntPtr(i);

    /// <summary>
    /// Adds an offset to a reference, measured relative to the reference type
    /// </summary>
    /// <param name="src">The soruce reference</param>
    /// <param name="bytes">The number of elements to advance</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seek<T>(ref T src, int count)
        where T : unmanaged
            => ref Unsafe.Add(ref src, count);

    /// <summary>
    /// Adds an offset to a reference, measured in bytes
    /// </summary>
    /// <param name="src">The soruce reference</param>
    /// <param name="bytes">The number of bytes to add</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seekb<T>(ref T src, long bytes)
        where T : unmanaged
            => ref Unsafe.AddByteOffset(ref src, intptr(bytes));

    /// <summary>
    /// Returns an readonly reference to a memory location, following a specified number of elements
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="elements">The number of elements to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skip<T>(in T src, int elements)
        where T : unmanaged
            => ref Unsafe.Add(ref As.asRef(in src), elements);

    /// <summary>
    /// Returns an readonly reference to a memory location, following a specified number of bytes
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="bytes">The number of elements to skip</param>
    /// <typeparam name="T">The source element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T skipb<T>(in T src, long bytes)
        where T : unmanaged
            => ref Unsafe.Add(ref As.asRef(in src), intptr(bytes));

}