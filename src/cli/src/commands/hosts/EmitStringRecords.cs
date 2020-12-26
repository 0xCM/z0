//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [WfHost]
    public sealed class EmitStringRecords : WfHost<EmitStringRecords>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitStringRecordsStep(wf,this);
            step.Run();
        }
    }

    ref struct EmitStringRecordsStep
    {
        /// <summary>
        /// The number of processed parts
        /// </summary>
        public uint PartCount;

        /// <summary>
        /// The number of emitted records after the run step has completed
        /// </summary>
        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IPart[] Parts;

        [MethodImpl(Inline)]
        public EmitStringRecordsStep(IWfShell wf, WfHost host)
        {
            Wf = wf.WithHost(host);
            Host = host;
            Parts = Wf.Api.Parts;
            EmissionCount = 0;
            PartCount = (uint)Parts.Length;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        uint EmitUserStrings(IPart part)
        {
            using var emitter = new EmitImageStringsStep(Wf, part, CliStringRecord.Kind.User, Wf.Ct);
            emitter.Run();
            return emitter.EmissionCount;
        }

        uint EmitSystemStrings(IPart part)
        {
            using var emitter = new EmitImageStringsStep(Wf, part, CliStringRecord.Kind.System, Wf.Ct);
            emitter.Run();
            return emitter.EmissionCount;
        }

        public void Run()
        {
            var flow = Wf.Running();

            foreach(var part in Parts)
            {
                EmissionCount += EmitUserStrings(part);
                EmissionCount += EmitSystemStrings(part);
            }

            Wf.Ran(flow, Seq.delimit(PartCount, EmissionCount));
        }
    }
}