//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using System;

    [Free]
    public interface IWfService : IDisposable
    {
        void Init(IWfShell wf);

        void IDisposable.Dispose()
        {

        }
    }

    /// <summary>
    /// Characterizes a workflow service implementation
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    [Free]
    public interface IWfService<H> : IWfService
        where H : IWfService<H>, new()
    {

    }
}