//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Root;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FixedEmitter<R>()
        where R : IFixed;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed8 FixedEmitter8();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 FixedEmitter16();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 FixedEmitter32();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 FixedEmitter64();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 FixedEmitter128();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 FixedEmitter256();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed8 FixedEmitter8<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 FixedEmitter16<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 FixedEmitter32<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 FixedEmitter64<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 FixedEmitter128<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 FixedEmitter256<T>()
        where T : unmanaged;
}