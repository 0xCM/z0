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
    public delegate FixedCell8 UnaryOp8(FixedCell8 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell16 UnaryOp16(FixedCell16 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 UnaryOp32(Fixed32 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell64 UnaryOp64(FixedCell64 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell128 UnaryOp128(FixedCell128 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell256 UnaryOp256(FixedCell256 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell512 UnaryOp512(FixedCell512 a);

}