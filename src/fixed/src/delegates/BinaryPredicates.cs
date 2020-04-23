//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate1(bit a, bit b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate8(Fixed8 a, Fixed8 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate16(Fixed16 a, Fixed16 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate32(Fixed32 a, Fixed32 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate64(Fixed64 a, Fixed64 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate128V(Fixed128V a, Fixed128V b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate256V(Fixed256V a, Fixed256V b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate512V(Fixed512V a, Fixed512V b);

}