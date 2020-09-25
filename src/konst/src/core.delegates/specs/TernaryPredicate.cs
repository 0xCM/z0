//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
   using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate bool TernaryPredicate<T>(T a, T b, T c);

    [Free]
    public delegate bool TernaryPredicate<W,T>(T a, T b, T c)
         where W : unmanaged, ITypeWidth;
}