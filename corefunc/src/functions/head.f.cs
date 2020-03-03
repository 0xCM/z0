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
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<N,T>(in NatSpan<N,T> src)
        where N : unmanaged, ITypeNat
        where T : unmanaged
            => ref src.Head;

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(in Block128<T> src)
        where T : unmanaged
            => ref src.Head;

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(in Block256<T> src)
        where T : unmanaged
            => ref src.Head;
}