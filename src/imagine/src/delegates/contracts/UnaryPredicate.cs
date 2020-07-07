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

}