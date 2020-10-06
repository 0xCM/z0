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
    using static ImageStringRecords;

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
            Wf = wf;
            Host = host;
            Parts = Wf.Api.Storage;
            EmissionCount = 0;
            PartCount = (uint)Parts.Length;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        uint EmitUserStrings(IPart part)
        {
            var dst = Wf.ResourceRoot + FolderName.Define(UserTargetFolder);
            using var emitter = new EmitPartStringsStep(Wf, part, PartStringKind.User, dst, Wf.Ct);
            emitter.Run();
            return emitter.EmissionCount;
        }

        uint EmitSystemStrings(IPart part)
        {
            var dst = Wf.ResourceRoot + FolderName.Define(SystemTargetFolder);
            using var emitter = new EmitPartStringsStep(Wf, part, PartStringKind.System, dst, Wf.Ct);
            emitter.Run();
            return emitter.EmissionCount;
        }

        public void Run()
        {
            Wf.Running(Host);

            foreach(var part in Parts)
            {
                EmissionCount += EmitUserStrings(part);
                EmissionCount += EmitSystemStrings(part);
            }

            Wf.Ran(Host, delimit(PartCount, EmissionCount));
        }
    }
}