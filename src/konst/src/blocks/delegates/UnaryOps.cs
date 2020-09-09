//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryOp1(bit a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell8 UnaryOp8(Cell8 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell16 UnaryOp16(Cell16 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell32 UnaryOp32(Cell32 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell64 UnaryOp64(Cell64 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell128 UnaryOp128(Cell128 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell256 UnaryOp256(Cell256 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell512 UnaryOp512(Cell512 a);

}