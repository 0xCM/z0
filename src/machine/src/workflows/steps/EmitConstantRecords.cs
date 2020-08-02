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

    public readonly ref struct EmitConstantRecords
    {
        readonly WfContext Wf;

        readonly FolderPath TargetDir;

        readonly IPart[] Parts;

        readonly CorrelationToken Correlation;
        
        [MethodImpl(Inline)]
        public EmitConstantRecords(WfContext wf, IPart[] parts, CorrelationToken? ct = null)
        {
            Wf = wf;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("constants");
            Parts = parts;
            Correlation = ct ?? CorrelationToken.create();
            Wf.Running(nameof(EmitConstantRecords), Correlation);
        }

        public EmissionDataType StepKind 
            => EmissionDataType.Konst;        

        public PartRecordKind DataKind
            => PartRecordKind.Constant;
                
        public ReadOnlySpan<ConstantRecord> Read(IPart part)
        {
            using var reader = PartReader.open(part.PartPath());
            return reader.ReadConstants();        
        }
        
        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath = TargetDir + FileName.Define(part.Id.Format(), FileExtensions.Csv);
            var ct = Wf.Running(nameof(EmitConstantRecords), dstPath);

            var data = Read(part);
            var count = data.Length;            
            var target = PartRecords.formatter(PartRecordSpecs.Constants);
            target.EmitHeader();
            for(var i=0u; i<count; i++)
                PartRecords.format(skip(data,i), target);

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            Wf.Ran(nameof(EmitConstantRecords), new {Id = id, Count = count}, ct);
        }
        
        public void Run()
        {
            var ct = Wf.Running(nameof(EmitConstantRecords));

            foreach(var part in Parts)
                Emit(part);
            
            Wf.Ran(nameof(EmitConstantRecords), ct);
        }

        public void Dispose()
        {
            Wf.Ran(nameof(EmitConstantRecords), Correlation);
        }
    }
}