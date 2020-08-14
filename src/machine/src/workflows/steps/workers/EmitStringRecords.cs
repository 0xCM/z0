//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitStringRecordsStep;
    
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

        /// <summary>
        /// The emission output rut
        /// </summary>
        public readonly FolderPath TargetDir;        

        readonly IWfContext Wf;

        readonly CorrelationToken Ct;
        
        readonly IPart[] Parts;
        
        [MethodImpl(Inline)]
        public EmitStringRecords(IWfContext wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            TargetDir = wf.ResourceRoot + FolderName.Define(TargetFolder);
            EmissionCount = 0;
            PartCount = (uint)parts.Length;
            Wf.Created(StepName, Ct);
        }
        
        uint EmitUserStrings(IPart part)
        {
            var dst = TargetDir + FileName.Define(part.Id.Format(), UserKindExt);
            using var emitter = new EmitPartStrings(Wf, part, true, dst, Ct);
            emitter.Run();                
            return emitter.EmissionCount;
        }

        uint EmitSystemStrings(IPart part)
        {
            var dst = TargetDir + FileName.Define(part.Id.Format(), SystemKindExt);
            using var emitter = new EmitPartStrings(Wf, part, false, dst, Ct);
            emitter.Run();                
            return emitter.EmissionCount;
        }
        
        public void Run()
        {
            Wf.RunningT(StepName, new {PartCount, TargetDir}, Ct);

            foreach(var part in Parts)
            {
                EmissionCount += EmitUserStrings(part);
                EmissionCount += EmitSystemStrings(part);
            }                

            Wf.RanT(StepName, new {PartCount, EmissionCount}, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }
    }
}