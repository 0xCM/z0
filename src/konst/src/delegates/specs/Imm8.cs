//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate A Imm8UnaryOp<A>(A a, byte b);

    [Free]
    public delegate A Imm8BinaryOp<A>(A a, A b, byte c);
}