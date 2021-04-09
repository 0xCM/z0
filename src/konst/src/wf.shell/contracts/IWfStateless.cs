//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using System;

    /// <summary>
    /// Characterizes a stateless <see cref='IWfService'/>
    /// </summary>
    /// <typeparam name="C">The contract type</typeparam>
    [Free]
    public interface IWfStateless<C> : IWfService
    {
        Type IService.ContractType
            => typeof(C);

        Type IService.HostType
            => GetType();

        void IWfService.Init(IWfRuntime wf){}
    }
}