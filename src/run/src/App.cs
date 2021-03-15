//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    class Runner
    {
        public static void Main(params string[] args)
        {
            var count = args.Length;
            if(count != 0)
                term.inform(string.Format("Command-line: {0}", args.Delimit()));

            if(ControlCommandRunner.specifies(args))
                ControlCommandRunner.dispatch(args);
            else
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
        }

        readonly IWfShell Wf;
    }
}