//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed8 PointedBinaryOp8(Fixed8 a, Fixed8 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 PointedBinaryOp32(Fixed32 a, Fixed32 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 PointedBinaryOp16(Fixed16 a, Fixed16 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 PointedBinaryOp64(Fixed64 a, Fixed64 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 PointedBinaryOp128(Fixed128 a, Fixed128 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128V PointedBinaryOp128V(Fixed128V a, Fixed128V b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 PointedBinaryOp256(Fixed256 a, Fixed256 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256V PointedBinaryOp256V(Fixed256V a, Fixed256V b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512 PointedBinaryOp512(Fixed512 a, Fixed512 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512V PointedBinaryOp512V(Fixed512V a, Fixed512V b);
}