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
    public delegate FixedCell8 Emitter8();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell16 Emitter16();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed32 Emitter32();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell64 Emitter64();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell128 Emitter128();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell256 Emitter256();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedCell512 Emitter512();
}