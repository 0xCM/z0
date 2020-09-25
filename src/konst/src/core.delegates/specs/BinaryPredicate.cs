//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate bit BinaryOp1(bit a, bit b);

    [Free]
    public delegate bit UnaryOp1(bit a);

    [Free]
    public delegate bit BinaryPredicate<T>(T a, T b);

    [Free]
    public delegate bit BinaryPredicate<W,T>(T a, T b)
         where W : unmanaged, ITypeWidth;
}