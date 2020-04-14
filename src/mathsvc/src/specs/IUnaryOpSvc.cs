//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Seed; 

    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOpSvc<T> : ISUnaryOpApi<T>, ISUnarySpanOpApi<T>
        where T : unmanaged
    {
        
    }
}