//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface INonZero<T>
        where T : unmanaged
    {
        T Value {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface INonZero<F,T> : INonZero<T>, IEquatable<F>  
        where F : unmanaged, INonZero<F,T>
        where T : unmanaged
    {

    }
}