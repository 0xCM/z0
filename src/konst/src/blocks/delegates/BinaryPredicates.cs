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
    public delegate bit BinaryPredicate8(FixedCell8 a, FixedCell8 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate16(FixedCell16 a, FixedCell16 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate32(Fixed32 a, Fixed32 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate64(FixedCell64 a, FixedCell64 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate128(FixedCell128 a, FixedCell128 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate256(FixedCell256 a, FixedCell256 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate512(FixedCell512 a, FixedCell512 b);

}