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
    public interface IWfRunner : IWfActor
    {
        void Run();
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfRunner<A> : IWfRunner
    {
        void Run(A args);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfRunner<H,A> : IWfRunner<H>
        where H : struct, IWfRunner<H,A>
    {
    }
}