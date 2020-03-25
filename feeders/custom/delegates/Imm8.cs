//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate A Imm8UnaryOp<A>(A a, byte b);

    [SuppressUnmanagedCodeSecurity]
    public delegate A Imm8BinaryOp<A>(A a, A b, byte c);
}