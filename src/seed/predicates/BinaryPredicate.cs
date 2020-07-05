//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate<T>(T a, T b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate<W,T>(T a, T b)
         where W : unmanaged, ITypeWidth;
}