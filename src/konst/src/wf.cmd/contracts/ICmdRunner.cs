//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface ICmdRunner
    {
        Type CommandType {get;}

        IEnumerable<WfCmdExec> Hosted {get;}
    }

    public interface ICmdRunner<K> : ICmdRunner
        where K : unmanaged

    {
        CmdResult Run(K command);

        Type ICmdRunner.CommandType
            => typeof(K);
    }
}