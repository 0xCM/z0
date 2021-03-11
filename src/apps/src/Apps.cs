//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct Apps
    {
        public static IAppContext context(IWfShell wf)
            => new AppContext(wf.Paths, wf.Api, Rng.@default(), WfShell.json(wf.Paths.AppConfigPath), MsgExchange.Create(wf));
    }
}