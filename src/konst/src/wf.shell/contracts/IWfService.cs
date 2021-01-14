//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using System;

    [Free]
    public interface IWfService : IService, IDisposable
    {
        IWfShell Wf {get;}


        void Init(IWfShell wf);


        void IDisposable.Dispose() {}
    }

    /// <summary>
    /// Characterizes a workflow service implementation
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    [Free]
    public interface IWfService<H> : IWfService, IService<H>
        where H : IWfService<H>, new()
    {

    }

    [Free]
    public interface IWfService<H,C> : IWfService<H>, IService<H,C>
        where H : IWfService<H,C>, new()
    {
        Type IService.ContractType
            => typeof(C);
    }
}