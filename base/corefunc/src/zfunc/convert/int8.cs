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

using Z0;
partial class zfunc
{
    [MethodImpl(Inline)]
    public static Span<sbyte> int8<T>(Span<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan<sbyte> int8<T>(ReadOnlySpan<T> src)
        where T : unmanaged
        => cast<T,sbyte>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan<sbyte> int8<T>(ReadOnlyMemory<T> src)
        where T : unmanaged
        => cast<T,sbyte>(src.Span);


    [MethodImpl(Inline)]
    public static Block128<sbyte> int8<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<sbyte> int8<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);

    [MethodImpl(Inline)]
    public static Block256<sbyte> int8<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);
        
    [MethodImpl(Inline)]
    public static ConstBlock256<sbyte> int8<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,sbyte>(src);

    [MethodImpl(Inline)]
    public static ref Vector128<sbyte> int8<T>(in Vector128<T> src)
        where T : unmanaged        
            => ref Unsafe.As<Vector128<T>,Vector128<sbyte>>(ref mutable(in src));

    [MethodImpl(Inline)]
    public static ref Vector256<sbyte> int8<T>(in Vector256<T> src)
        where T : unmanaged        
            => ref Unsafe.As<Vector256<T>,Vector256<sbyte>>(ref mutable(in src));
}