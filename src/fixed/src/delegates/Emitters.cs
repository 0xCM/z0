//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit Emitter1();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed8 Emitter8();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed16 Emitter16();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 Emitter32();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed64 Emitter64();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128V Emitter128V();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256V Emitter256V();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed512V Emitter512V();
}