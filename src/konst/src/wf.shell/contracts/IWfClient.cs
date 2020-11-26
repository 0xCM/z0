//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IWfClient
    {
        IWfShell Wf {get;}
    }

    public interface IWfClient<C> : IWfClient
    {
        C Context {get;}
    }


    [Free]
    public interface IWfService : IWfClient
    {

    }
}