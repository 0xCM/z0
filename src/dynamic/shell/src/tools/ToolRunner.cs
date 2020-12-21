//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    public struct ToolRunner : IDisposable
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly Multiplex Mpx;

        readonly string[] Args;

        readonly CmdBuilder CmdBuilder;

        readonly IWfDb Db;

        public ToolRunner(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Mpx = Multiplex.create(wf, Multiplex.configure(wf.Db().Root));
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


        void RunAll()
        {
            //EmitPatterns();
            //EmitToolHelp();
            //EmitAsmRefs();
        }


        public void Run()
        {
            var models = @readonly(Cmd.cmdtypes(Wf));
            var count = models.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var model = ref skip(models,i);
                Wf.Row(string.Format("{0,-3} {1}", i, model.DataType.Name));
            }
        }
    }
}