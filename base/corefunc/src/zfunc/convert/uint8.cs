//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;    

using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]
    public static Span<byte> uint8<T>(Span<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan<byte> uint8<T>(in ReadOnlySpan<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan<byte> uint8<T>(in ReadOnlyMemory<T> src)
        where T : unmanaged
            => cast<T,byte>(src.Span);

    [MethodImpl(Inline)]
    public static Block128<byte> uint8<T>(in Block128<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    [MethodImpl(Inline)]
    public static ConstBlock128<byte> uint8<T>(in ConstBlock128<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    [MethodImpl(Inline)]
    public static Block256<byte> uint8<T>(in Block256<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    [MethodImpl(Inline)]
    public static ConstBlock256<byte> uint8<T>(in ConstBlock256<T> src)
        where T : unmanaged
            => cast<T,byte>(src);

    [MethodImpl(Inline)]
    public static ref Vector128<byte> uint8<T>(in Vector128<T> src)
        where T : unmanaged        
            => ref Unsafe.As<Vector128<T>,Vector128<byte>>(ref mutable(in src));

    [MethodImpl(Inline)]
    public static ref Vector256<byte> uint8<T>(in Vector256<T> src)
        where T : unmanaged        
            => ref Unsafe.As<Vector256<T>,Vector256<byte>>(ref mutable(in src));

    [MethodImpl(Inline)]
    public static byte uint8<T>(T src)
        => Unsafe.As<T,byte>(ref src);

    [MethodImpl(Inline)]
    public static byte? uint8<T>(T? src)
        where T : unmanaged
            => Unsafe.As<T?, byte?>(ref src);

}