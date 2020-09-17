//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate<T>(T a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate<W,T>(T a)
         where W : unmanaged, ITypeWidth;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate1(bit a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate8(Cell8 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate16(Cell16 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate32(Cell32 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate64(Cell64 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate128(Cell128 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate256(Cell256 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit UnaryPredicate512(Cell512 a);

}