//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IWfCmdHost : IWfService
    {
        Type CommandType {get;}

        IEnumerable<WfCmdExec> Hosted {get;}
    }

    public interface IWfCmdHost<K> : IWfCmdHost
        where K : unmanaged
    {
        CmdResult Run(K kind);

        Type IWfCmdHost.CommandType
            => typeof(K);
    }
}