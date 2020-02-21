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
    public delegate Fixed8 Emitter8();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 Emitter16();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 Emitter32();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 Emitter64();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 Emitter128();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 Emitter256();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512 Emitter512();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed8 Emitter8<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 Emitter16<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 Emitter32<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 Emitter64<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 Emitter128<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 Emitter256<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512 Emitter512<T>()
        where T : unmanaged;
}