//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitImageConstantsStep;
    using static RenderPatterns;
    using static z;

    public readonly ref struct EmitImageConstants
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly FolderPath TargetDir;

        readonly IPart[] Parts;

        [MethodImpl(Inline)]
        public EmitImageConstants(IWfShell wf, IPart[] parts, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = parts;
            TargetDir = wf.ResourceRoot + FolderName.Define("constants");
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId);

            foreach(var part in Parts)
            {
                try
                {
                    Emit(part);
                }
                catch(Exception e)
                {
                    Wf.Error(StepId, e);
                }
            }

            Wf.Ran(StepId);
        }

        ReadOnlySpan<ImageConstantRecord> Read(IPart part)
        {
            using var reader = PeTableReader.open(part.PartPath());
            return reader.ReadConstants();
        }

        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath = TargetDir + FileName.define(id.Format(), DataExt);
            Wf.Running(StepId, dstPath.Name);

            var data = Read(part);
            var count = data.Length;
            var dst = PartRecords.formatter(ImageRecords.Constants);

            dst.EmitHeader();
            for(var i=0u; i<count; i++)
                PartRecords.format(skip(data,i), dst);

            using var writer = dstPath.Writer();
            writer.Write(dst.Render());

            Wf.Ran(StepId, delimit(id, count));
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }
    }
}