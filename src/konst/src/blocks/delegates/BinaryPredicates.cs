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
    public delegate bit BinaryPredicate8(Cell8 a, Cell8 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate16(Cell16 a, Cell16 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate32(Cell32 a, Cell32 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate64(Cell64 a, Cell64 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate128(Cell128 a, Cell128 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate256(Cell256 a, Cell256 b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate512(Cell512 a, Cell512 b);

}