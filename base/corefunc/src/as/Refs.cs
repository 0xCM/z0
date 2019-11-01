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
    public static ref T advance<T>(ref T src, int count)
        where T : unmanaged
            => ref Unsafe.Add(ref src, count);

    /// <summary>
    /// Adds an offset to a reference, measured in bytes
    /// </summary>
    /// <param name="src">The soruce reference</param>
    /// <param name="bytes">The number of bytes to add</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T advanceb<T>(ref T src, long bytes)
        where T : unmanaged
            => ref Unsafe.AddByteOffset(ref src, intptr(bytes));

}