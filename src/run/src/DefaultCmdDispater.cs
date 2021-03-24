//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    readonly struct DefaultCmdDispatcher
    {
        public static void dispatch(string[] args)
        {
            try
            {
                var parts = WfShell.parts(Index<PartId>.Empty);
                term.inform(AppMsg.status(text.prop("PartCount", parts.Components.Length)));
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
    }
}