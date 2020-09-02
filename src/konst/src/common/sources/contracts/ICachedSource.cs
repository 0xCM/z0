//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ICachedSource : ISource
    {
        ref readonly T Next<T>()
            where T : struct;
    }
    
    [SuppressUnmanagedCodeSecurity]
    public interface ICachedSource<T> : ISource<T>
        where T : struct
    {        
        new ref readonly T Next();

        T ISource<T>.Next() 
            => Next();
    }
}