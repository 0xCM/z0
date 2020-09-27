//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate Bit32 UnaryPredicate<T>(T a);

    [Free]
    public delegate Bit32 UnaryPredicate<W,T>(T a)
         where W : unmanaged, ITypeWidth;
}