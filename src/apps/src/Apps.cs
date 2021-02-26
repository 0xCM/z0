//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public readonly struct Apps
    {
        public static void react(params string[] args)
        {
            try
            {
                var parts = WfShell.parts(Index<PartId>.Empty);
                term.inform(AppMsg.status(text.prop("PartCount", parts.PartComponents.Length)));
                var rng = Rng.@default();
                using var wf = WfShell.create(parts, args).WithRandom(rng);
                if(args.Length == 0)
                {
                    wf.Status("usage: run <command> [options]");
                    var settings = wf.Settings;
                    wf.Row(settings.Format());
                }
                else
                {
                    wf.Status("Dispatching");
                    Reactor.init(wf).Dispatch(args);
                }

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public static IAppContext context(IWfShell wf)
            => new AppContext(wf.Paths, wf.Api, Rng.@default(), WfShell.json(wf.Paths.AppConfigPath), MsgExchange.Create(wf));

        public static IAppContext context(IWfShell wf, IPolyrand random)
            => new AppContext(wf.Paths, wf.Api, random, WfShell.json(wf.Paths.AppConfigPath), MsgExchange.Create(wf));

    }
}