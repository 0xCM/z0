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
    public delegate Fixed8 BinaryOp8(Fixed8 a, Fixed8 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 BinaryOp32(Fixed32 a, Fixed32 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 BinaryOp16(Fixed16 a, Fixed16 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 BinaryOp64(Fixed64 a, Fixed64 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 BinaryOp128(Fixed128 a, Fixed128 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 BinaryOp256(Fixed256 a, Fixed256 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512 BinaryOp512(Fixed512 a, Fixed512 b);
}