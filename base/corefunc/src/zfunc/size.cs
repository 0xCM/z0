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
    /// Computes the size, in bytes of a source value of specified type
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static ByteSize size<T>()
        where T : struct
            => Unsafe.SizeOf<T>();

    /// <summary>
    /// Computes the size, in bits of a source value of specified type
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static BitSize bitsize<T>()
        where T : struct
            => Unsafe.SizeOf<T>()*8;
}