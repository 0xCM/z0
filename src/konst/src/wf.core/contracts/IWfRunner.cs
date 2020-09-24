//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfRunner : IWfActor
    {
        void Run();
    }

    [Free]
    public interface IWfRunner<A> : IWfRunner
    {
        void Run(A args);
    }

    [Free]
    public interface IWfRunner<H,A> : IWfRunner<H>
        where H : struct, IWfRunner<H,A>
    {
    }
}