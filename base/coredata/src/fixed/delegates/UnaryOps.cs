//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Security;

    using static zfunc;

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
    public delegate Fixed256 UnaryOp256(Fixed256 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512 UnaryOp512(Fixed512 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed8 UnaryOp8<T>(Fixed8 a)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 UnaryOp16<T>(Fixed16 a)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 UnaryOp32<T>(Fixed32 a)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 UnaryOp64<T>(Fixed64 a)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 UnaryOp128<T>(Fixed128 a)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 UnaryOp256<T>(Fixed256 a)
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512 UnaryOp512<T>(Fixed512 a)
        where T : unmanaged;

}