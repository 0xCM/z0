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
    /// Returns the number of components that comprise a 128-bit vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static int vlength<T>(N128 n)
        where T : unmanaged
            => Vector128<T>.Count;

    /// <summary>
    /// Returns the number of components that comprise a 256-bit vector
    /// </summary>
    /// <param name="n">The bitness selector</param>
    /// <typeparam name="T">The primal component type</typeparam>
    [MethodImpl(Inline)]
    public static int vlength<T>(N256 n)
        where T : unmanaged
            => Vector256<T>.Count;
}