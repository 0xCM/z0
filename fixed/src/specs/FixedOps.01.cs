//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryOp1(bit a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed8 UnaryOp8(Fixed8 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 UnaryOp16(Fixed16 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 UnaryOp32(Fixed32 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 UnaryOp64(Fixed64 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 UnaryOp128(Fixed128 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128V UnaryOp128V(Fixed128V a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 UnaryOp256(Fixed256 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256V UnaryOp256V(Fixed256V a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512 UnaryOp512(Fixed512 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512V UnaryOp512V(Fixed512V a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate1(bit a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate8(Fixed8 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate16(Fixed16 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate32(Fixed32 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate64(Fixed64 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate128V(Fixed128V a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate256V(Fixed256V a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate512V(Fixed512V a);
}