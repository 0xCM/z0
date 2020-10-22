//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static WfSteps Steps(this IWfShell wf)
            => new WfSteps(wf);
    }

    public readonly struct WfSteps
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly ConcurrentDictionary<ulong,IWfHost> Hosts;

        readonly CmdRouter Router;

        [MethodImpl(Inline)]
        public WfSteps(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(WfSteps));
            Wf = wf.WithHost(Host);
            Hosts = new ConcurrentDictionary<ulong, IWfHost>();
            Router = Cmd.router(Wf);
        }

        [CmdWorker]
        public static void exec(IWfShell wf, in EmitAssemblyRefsSpec cmd)
        {
            var host = Cmd.host(cmd);
            using var reader = Reader(wf,cmd.Source);
            using var writer = cmd.Target.Writer();
            var data = reader.AssemblyReferences();
            var count = data.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(z.skip(data,i).Name);
        }

        [MethodImpl(Inline)]
        static CliMemoryMap Reader(IWfShell wf, FS.FilePath src)
            => CliMemoryMap.create(wf, src);

        void Run666()
        {
            var build = FS.dir(@"k:\z0\builds\nca.3.1.win-x64");
            var cmd = new EmitAssemblyRefsSpec();
            cmd.Source = build + FS.file("z0.konst.dll");
            cmd.Target = Wf.AppData + FS.file("AssemblyReferences", "csv");
            exec(Wf,cmd);

        }
    }
}