//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    using static Konst;

    [SuppressUnmanagedCodeSecurity]
    public interface IWfRunner
    {
        void Run(params string[] args);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfRunner<T> : IWfRunner
        where T : struct, IWfStep<T>
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfRunner<T,K> : IWfRunner<T>
        where T : struct, IWfStep<T,K>
        where K : unmanaged, Enum
    {
        
    }
}