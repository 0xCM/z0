//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static z;

    using W = Windows;

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
                    if(args.Length == 1 && args[0] == "tests")
                        app.RunTests();
                    else
                    {
                        wf.Status("Dispatching");
                        Reactor.init(wf).Dispatch(args);
                    }
                }

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void RunTests()
        {
            var src = FS.path(@"K:\dumps\capture.dmp");
            if(src.Exists)
            {
                using var file = MemoryFiles.map(src);
                Wf.Status($"Mapped file {file.Path} to process memory based at {file.BaseAddress}");
                ref readonly var header = ref file.One<W.MINIDUMP_HEADER>(0);
                asci4 sig = header.Signature;
                Wf.Row(string.Format("Sig:{0}, Version:{1}, NumerOfStreams:{2}, Flags:{3}",
                    sig, header.Version & ushort.MaxValue, header.NumberOfStreams, header.Flags));
            }
        }
    }
}