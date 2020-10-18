//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
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
            var dst = Wf.Db().Table(AsmCallRecord.TableId, Source.Part);
            Wf.EmittingFile(Source.Part, dst);
            using var writer = dst.Writer();
            var records = @readonly(Source.Instructions.CallRecords());
            var count = records.Length;
            writer.WriteLine(AsmCallRecord.header());
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmCallRecord.format(skip(records,i)));
            Wf.EmittedTable<AsmCallRecord>(count, dst);
        }
    }
}