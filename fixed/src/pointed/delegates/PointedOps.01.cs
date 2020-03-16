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
    public delegate Fixed8 PointedUnaryOp8(Fixed8 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 PointedUnaryOp16(Fixed16 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 PointedUnaryOp32(Fixed32 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 PointedUnaryOp64(Fixed64 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 PointedUnaryOp128(Fixed128 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128V PointedUnaryOp128V(Fixed128V a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 PointedUnaryOp256(Fixed256 a);


    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256V PointedUnaryOp256V(Fixed256V a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512 PointedUnaryOp512(Fixed512 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512V PointedUnaryOp512V(Fixed512V a);


}