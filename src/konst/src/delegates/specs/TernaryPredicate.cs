//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate bit TernaryPredicate<T>(T a, T b, T c);

    [Free]
    public delegate bit TernaryPredicate<W,T>(T a, T b, T c)
         where W : unmanaged, ITypeWidth;
}