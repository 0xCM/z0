//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using System;

    [Free]
    public interface IAppService : IService, IDisposable
    {
        IWfRuntime Wf {get;}

        EnvData Env => Wf.Env;

        IWfDb Db => Wf.Db();

        void Init(IWfRuntime wf);


        void IDisposable.Dispose() {}
    }

    /// <summary>
    /// Characterizes a workflow service implementation
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    [Free]
    public interface IAppService<H> : IAppService, IService<H>
        where H : IAppService<H>, new()
    {

    }

    [Free]
    public interface IAppService<H,C> : IAppService<H>, IService<H,C>
        where H : IAppService<H,C>, new()
    {
        Type IService.ContractType
            => typeof(C);
    }
}