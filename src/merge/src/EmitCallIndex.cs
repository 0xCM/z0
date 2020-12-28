//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static z;

    [WfHost]
    public sealed class EmitCallIndex : WfHost<EmitCallIndex>
    {
        ApiPartRoutines Routines;

        public static WfHost create(in ApiPartRoutines routines)
        {
            var host = new EmitCallIndex();
            host.Routines = routines;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitCallIndexStep(wf, this, Routines);
            step.Run();
        }
    }

    ref struct EmitCallIndexStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiPartRoutines Source;

        public EmitCallIndexStep(IWfShell wf, WfHost host, ApiPartRoutines src)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Source = src;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }


        public void Run()
        {
            var dst = Wf.Db().Table(AsmCallRow.TableId, Source.Part);
            Wf.EmittingTable<AsmCallRow>(dst);
            using var writer = dst.Writer();
            var records = @readonly(AsmQueries.calls(Source.Instructions));
            var count = records.Length;
            writer.WriteLine(AsmCallRow.header());
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmCallRow.format(skip(records,i)));
            Wf.EmittedTable<AsmCallRow>(count, dst);
        }
    }
}