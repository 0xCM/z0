//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPredicate<T>(T a, T b, T c);        

    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPredicate<W,T>(T a, T b, T c)    
         where W : unmanaged, ITypeWidth; 
}