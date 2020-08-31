//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitPartCilStep;

    using static z;

    public ref struct EmitPartCil
    {
        readonly IWfShell Wf;

        public readonly FolderPath TargetDir;

        public uint EmissionCount;

        public uint PartCount;

        readonly IPart[] Parts;

        readonly CorrelationToken Ct;

        [MethodImpl(Inline)]
        public EmitPartCil(IWfShell wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            PartCount = (uint)parts.Length;
            TargetDir = Wf.ResourceRoot + FolderName.Define(DataFolder);
            EmissionCount = 0;
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId, delimit(PartCount, TargetDir));

            foreach(var part in Parts)
            {
                try
                {
                    EmissionCount += Emit(part, TargetDir + FileName.define(part.Id.Format(), DatasetExt));
                }
                catch(Exception e)
                {
                    Wf.Error(e, Ct);
                }
            }

            Wf.Running(StepId, delimit(PartCount, TargetDir, EmissionCount));
        }

        uint Emit(IPart part, FilePath dst)
        {
            Wf.Emitting(StepId, EmissionType, dst);

            var methods = PeTableReader.methods(FS.path(part.Owner.Location));
            var count = (uint)methods.Length;
            using var writer = dst.Writer();
            writer.WriteLine(ImageMethodBody.Header);

            for(var i=0u; i<count; i++)
                writer.WriteLine(skip(methods,i).Format());

            Wf.Emitted(StepId, EmissionType, count, dst);
            return count;
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }
    }
}