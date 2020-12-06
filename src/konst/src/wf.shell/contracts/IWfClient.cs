//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfClient
    {
        IWfShell Wf {get;}
    }

    [Free]
    public interface IWfClient<C> : IWfClient
        where C : IWfClient<C>, new()
    {
        C Init(IWfShell wf);
    }
}