//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate R FuncIn<A,R>(in A a);

    [SuppressUnmanagedCodeSecurity]
    public delegate R FuncIn<A,B,R>(in A a, in B b);

    [SuppressUnmanagedCodeSecurity]
    public delegate R FuncIn<A,B,C,R>(in A a, in B b, in C c);
}