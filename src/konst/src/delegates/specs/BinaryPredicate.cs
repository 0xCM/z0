//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate bit BinaryPredicate<T>(T a, T b);

    [Free]
    public delegate bit BinaryPredicate<W,T>(T a, T b)
         where W : unmanaged, ITypeWidth;

    [Free]
    public delegate bit BinaryPredicate1(bit a, bit b);

    [Free]
    public delegate bit BinaryPredicate8(Cell8 a, Cell8 b);

    [Free]
    public delegate bit BinaryPredicate16(Cell16 a, Cell16 b);

    [Free]
    public delegate bit BinaryPredicate32(Cell32 a, Cell32 b);

    [Free]
    public delegate bit BinaryPredicate64(Cell64 a, Cell64 b);

    [Free]
    public delegate bit BinaryPredicate128(Cell128 a, Cell128 b);

    [Free]
    public delegate bit BinaryPredicate256(Cell256 a, Cell256 b);

    [Free]
    public delegate bit BinaryPredicate512(Cell512 a, Cell512 b);
}