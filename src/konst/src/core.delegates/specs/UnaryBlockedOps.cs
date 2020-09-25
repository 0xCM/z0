//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate ref readonly SpanBlock8<T> UnaryBlockedOp8<T>(in SpanBlock8<T> src, in SpanBlock8<T> dst)
        where T : unmanaged;

    [Free]
    public delegate ref readonly SpanBlock16<T> UnaryBlockedOp16<T>(in SpanBlock16<T> src, in SpanBlock16<T> dst)
        where T : unmanaged;

    [Free]
    public delegate ref readonly SpanBlock32<T> UnaryBlockedOp32<T>(in SpanBlock32<T> src, in SpanBlock32<T> dst)
        where T : unmanaged;

    [Free]
    public delegate ref readonly SpanBlock64<T> UnaryBlockedOp64<T>(in SpanBlock64<T> src, in SpanBlock64<T> dst)
        where T : unmanaged;

    [Free]
    public delegate ref readonly SpanBlock128<T> UnaryBlockedOp128<T>(in SpanBlock128<T> src, in SpanBlock128<T> dst)
        where T : unmanaged;

    [Free]
    public delegate ref readonly SpanBlock256<T> UnaryBlockedOp256<T>(in SpanBlock256<T> src, in SpanBlock256<T> dst)
        where T : unmanaged;

    [Free]
    public delegate ref readonly SpanBlock512<T> UnaryBlockedOp512<T>(in SpanBlock512<T> src, in SpanBlock512<T> dst)
        where T : unmanaged;
}