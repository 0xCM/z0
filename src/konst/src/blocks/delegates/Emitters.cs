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
    public delegate Cell8 Emitter8();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell16 Emitter16();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell32 Emitter32();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell64 Emitter64();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell128 Emitter128();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell256 Emitter256();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell512 Emitter512();
}