//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct Apps
    {
        static IJsonSettings json(FS.FilePath src)
            => JsonSettings.Load(src);

        public static IWfRuntime runtime(string[] args)
            => WfRuntime.create(ApiQuery.parts(root.controller(), args), args).WithSource(Rng.@default());

        public static IAppContext context(IWfRuntime wf)
            => new AppContext(wf.Paths, wf.ApiCatalog, Rng.@default(), json(wf.Paths.AppConfigPath), MsgExchange.Create());
    }
}