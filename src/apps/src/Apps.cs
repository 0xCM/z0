//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct Apps
    {
        static IJsonSettings json(FS.FilePath src)
            => JsonSettings.Load(src);

        public static IAppContext context(IWfRuntime wf)
            => new AppContext(wf.Paths, wf.Api, Rng.@default(), json(wf.Paths.AppConfigPath), MsgExchange.Create());
    }
}