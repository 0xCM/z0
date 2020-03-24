//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block128<T> UnaryBlockedOp128Imm8<T>(in Block128<T> src, byte imm8, in Block128<T> dst)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate ref readonly Block256<T> UnaryBlockedOp256Imm8<T>(in Block256<T> src, byte imm8, in Block256<T> dst)
        where T : unmanaged;

}