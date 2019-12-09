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
using System.Diagnostics;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Computes the byte-size of a type
    /// </summary>
    /// <typeparam name="T">The type</typeparam>
    [MethodImpl(Inline)]
    public static ByteSize size<T>()
        where T : struct
            => Unsafe.SizeOf<T>();

    /// <summary>
    /// Computes the byte-size of a type
    /// </summary>
    /// <param name="t">A type representative</param>
    /// <typeparam name="T">The type</typeparam>
    [MethodImpl(Inline)]
    public static ByteSize size<T>(T t)
        where T : struct
            => Unsafe.SizeOf<T>();

    /// <summary>
    /// Computes the bit-width of a type
    /// </summary>
    /// <typeparam name="T">The type</typeparam>
    [MethodImpl(Inline)]
    public static int bitsize<T>()
        where T : struct
            => Unsafe.SizeOf<T>()*8;

    /// <summary>
    /// Computes the bit-width of a type
    /// </summary>
    /// <param name="t">A type representative</param>
    /// <typeparam name="T">The type</typeparam>    
    [MethodImpl(Inline)]
    public static int bitsize<T>(T t)
        where T : struct
            => Unsafe.SizeOf<T>()*8;

}