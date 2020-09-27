//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate Bit32 BinaryOp1(Bit32 a, Bit32 b);

    [Free]
    public delegate Bit32 UnaryOp1(Bit32 a);

    [Free]
    public delegate Bit32 BinaryPredicate<T>(T a, T b);

    [Free]
    public delegate bool BinaryPredicate8<T>(T a, T b);

    [Free]
    public delegate Bit32 BinaryPredicate<W,T>(T a, T b)
         where W : unmanaged, ITypeWidth;
}