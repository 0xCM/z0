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
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly CmdBuilder Builder;

        readonly IWfDb Db;

        Runner(IWfShell wf)
        {
            Host = WfShell.host(typeof(Runner));
            Wf = wf.WithHost(Host);
            Builder = wf.CmdBuilder();
            Db = wf.Db();
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(WfShell.parts(Index<PartId>.Empty), args);
                var app = new Runner(wf);
                if(args.Length == 0)
                {
                    wf.Status("usage: run <command> [options]");
                    var settings = wf.Settings;
                    wf.Row(settings.Format());
                }
                else
                {
                    app.Test();
                    wf.Status("Dispatching");
                    Reactor.init(wf).Dispatch(args);
                }

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Test()
        {
            var src = FS.path(@"K:\dumps\capture.dmp");
            using var file = MemoryFiles.map(src)
        }

    }
}