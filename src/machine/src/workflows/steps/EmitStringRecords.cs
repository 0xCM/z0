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
    using static EmitStringRecordHost;

    public ref struct EmitStringRecords
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

        readonly EmitStringRecordHost Host;

        readonly CorrelationToken Ct;


        readonly IPart[] Parts;

        [MethodImpl(Inline)]
        public EmitStringRecords(IWfShell wf, EmitStringRecordHost host)
        {
            Wf = wf;
            Ct = Wf.Ct;
            Host = host;
            Parts = Wf.Api.Parts;
            EmissionCount = 0;
            PartCount = (uint)Parts.Length;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        uint EmitUserStrings(IPart part)
        {
            var dst = Wf.ResourceRoot + FolderName.Define(UserTargetFolder);
            using var emitter = new EmitPartStrings(Wf, part, PartStringKind.User, dst, Ct);
            emitter.Run();
            return emitter.EmissionCount;
        }

        uint EmitSystemStrings(IPart part)
        {
            var dst = Wf.ResourceRoot + FolderName.Define(SystemTargetFolder);
            using var emitter = new EmitPartStrings(Wf, part, PartStringKind.System, dst, Ct);
            emitter.Run();
            return emitter.EmissionCount;
        }

        public void Run()
        {
            Wf.Running(StepId);

            foreach(var part in Parts)
            {
                EmissionCount += EmitUserStrings(part);
                EmissionCount += EmitSystemStrings(part);
            }

            Wf.Ran(StepId, delimit(PartCount, EmissionCount));
        }
    }
}