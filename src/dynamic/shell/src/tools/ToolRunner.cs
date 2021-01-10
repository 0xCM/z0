//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;


    public interface IToolRunner : IDisposable
    {
        void Run();

        void ShowCommands();
    }

    public sealed class ToolRunner : IToolRunner
    {
        public static void run(IWfShell wf, CmdLine cmd)
        {
            var process = Cmd.process(wf, cmd).Wait();
            var output = process.Output;
            wf.Status(output);
        }

        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly Index<string> Args;

        readonly CmdBuilder CmdBuilder;

        readonly IWfDb Db;

        public ToolRunner(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Args = wf.Args;
            CmdBuilder = wf.CmdBuilder();
            Db = Wf.Db();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        void ShowArgs()
        {
            for(var i=0; i<Args.Length; i++)
                Wf.Row(Args[i]);
        }

        public void ShowCommands()
        {
            var models = @readonly(Cmd.cmdtypes(Wf));
            var count = models.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var model = ref skip(models,i);
                Wf.Row(string.Format("{0,-3} {1}", i, model.DataType.Name));
            }
        }

        public void Run()
        {

        }
    }
}