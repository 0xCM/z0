//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly SpanBlock128<T> UnaryBlockedOp128Imm8<T>(in SpanBlock128<T> src, byte imm8, in SpanBlock128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly SpanBlock256<T> UnaryBlockedOp256Imm8<T>(in SpanBlock256<T> src, byte imm8, in SpanBlock256<T> dst)
        where T : unmanaged;
}