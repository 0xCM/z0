//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;    
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Computes the vector component count for a given bit-width and component type
    /// </summary>
    /// <param name="w">The width selector</param>
    /// <typeparam name="T">The vector component type</typeparam>
    [MethodImpl(Inline)]
    public static int vcount<W,T>(W w = default, T t = default)
        where W : unmanaged, ITypeNat
        where T : unmanaged
            => TypeMath.div(w,t);

    /// <summary>
    /// Computes the vector component count for a given bit-width and component type
    /// </summary>
    /// <param name="w">The width selector</param>
    /// <typeparam name="T">The vector component type</typeparam>
    [MethodImpl(Inline)]
    public static int vcount<T>(N128 w, T t = default)
        where T : unmanaged
            => Vector128<T>.Count;

    /// <summary>
    /// Computes the vector component count for a given bit-width and component type
    /// </summary>
    /// <param name="w">The width selector</param>
    /// <typeparam name="T">The vector component type</typeparam>
    [MethodImpl(Inline)]
    public static int vcount<T>(N256 w, T t = default)
        where T : unmanaged
            => Vector256<T>.Count;
}