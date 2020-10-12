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
    public sealed class EmitCallIndex : WfHost<EmitCallIndex,ApiPartRoutines>
    {
        protected override void Execute(IWfShell wf, in ApiPartRoutines state)
        {
            using var step = new EmitCallIndexStep(wf, this, state);
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
            //var records = Source.Instructions.CallRecords();
            var calls = Source.Instructions.CallAspects;
            var delimited = calls.Select(x => Render.delimit(x.Rows, FieldDelimiter));
            var names = Render.delimit(AsmCallInfo.AspectNames, FieldDelimiter);
            writer.WriteLine(names);
            iter(delimited, writer.WriteLine);

            Wf.EmittedFile(Source.Part, calls.Length, dst);
        }
    }
}