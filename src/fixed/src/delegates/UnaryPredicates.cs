//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

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