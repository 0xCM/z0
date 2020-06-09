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
    public delegate bit BinaryPredicate<T>(T a, T b);

    [SuppressUnmanagedCodeSecurity]
    public delegate bit BinaryPredicate<W,T>(T a, T b)
         where W : unmanaged, ITypeWidth;

    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPredicate<T>(T a, T b, T c);        

    [SuppressUnmanagedCodeSecurity]
    public delegate bit TernaryPredicate<W,T>(T a, T b, T c)    
         where W : unmanaged, ITypeWidth; 
}