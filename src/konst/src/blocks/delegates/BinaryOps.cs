//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryOp1(bit a, bit b);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell8 BinaryOp8(FixedCell8 a, FixedCell8 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 BinaryOp32(Fixed32 a, Fixed32 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell16 BinaryOp16(FixedCell16 a, FixedCell16 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell64 BinaryOp64(FixedCell64 a, FixedCell64 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell128 BinaryOp128(FixedCell128 a, FixedCell128 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell256 BinaryOp256(FixedCell256 a, FixedCell256 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell512 BinaryOp512(FixedCell512 a, FixedCell512 b);
}