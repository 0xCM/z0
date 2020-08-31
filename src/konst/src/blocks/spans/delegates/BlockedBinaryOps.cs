//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly SpanBlock8<T> BinaryBlockedOp8<T>(in SpanBlock8<T> a, in SpanBlock8<T> b, in SpanBlock8<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly SpanBlock16<T> BinaryBlockedOp16<T>(in SpanBlock16<T> a, in SpanBlock16<T> b, in SpanBlock16<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly SpanBlock32<T> BinaryBlockedOp32<T>(in SpanBlock32<T> a, in SpanBlock32<T> b, in SpanBlock32<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly SpanBlock64<T> BinaryBlockedOp64<T>(in SpanBlock64<T> a, in SpanBlock64<T> b, in SpanBlock64<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly SpanBlock128<T> BinaryBlockedOp128<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly SpanBlock256<T> BinaryBlockedOp256<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly SpanBlock512<T> BinaryBlockedOp512<T>(in SpanBlock512<T> a, in SpanBlock512<T> b, in SpanBlock512<T> dst)
        where T : unmanaged;
}