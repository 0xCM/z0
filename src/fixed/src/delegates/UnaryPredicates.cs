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
    public delegate bit UnaryPredicate128(Fixed128 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate256(Fixed256 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate512(Fixed512 a);
}