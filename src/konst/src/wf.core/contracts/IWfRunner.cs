//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfRunner : IWfActor
    {
        void Run();
    }

    [Free]
    public interface IWfRunner<A>
    {
        void Run(A args);
    }

    [Free]
    public interface IWfRunner<H,A> : IWfRunner<H>
        where H : IWfRunner<H,A>
    {
    }
}