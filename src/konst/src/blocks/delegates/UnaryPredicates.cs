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
    public delegate bit UnaryPredicate8(FixedCell8 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate16(FixedCell16 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate32(Fixed32 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate64(FixedCell64 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate128(FixedCell128 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate256(FixedCell256 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate512(FixedCell512 a);
}