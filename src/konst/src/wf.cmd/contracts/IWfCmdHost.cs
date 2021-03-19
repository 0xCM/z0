//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWfCmdHost : IWfService, ICmdRunner
    {

    }

    public interface IWfCmdHost<K> : IWfCmdHost, ICmdRunner<K>
        where K : unmanaged
    {

    }
}