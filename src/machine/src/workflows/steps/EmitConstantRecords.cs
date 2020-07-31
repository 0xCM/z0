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
        readonly IAppContext Wf;

        readonly FolderPath TargetDir;

        readonly IPart[] Parts;
        
        [MethodImpl(Inline)]
        public EmitConstantRecords(IAppContext wf, IPart[] parts)
        {
            Wf = wf;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("constants");
            Parts = parts;
            Wf.Running(nameof(EmitConstantRecords));
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
            PartDataEmitters.emitting(DataKind, dstPath, Wf);

            var data = Read(part);
            var count = data.Length;            
            var target = PartRecords.formatter(PartRecordSpecs.Constants);
            target.EmitHeader();
            for(var i=0u; i<count; i++)
                PartRecords.format(skip(data,i), target);

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            TableEmission.emitted(Wf, DataKind, id, count);
        }
        
        public void Run()
        {
            PartDataEmitters.emitting(StepKind, Wf);

            foreach(var part in Parts)
                Emit(part);
            
            PartDataEmitters.emitted(StepKind, Wf);
        }

        public void Dispose()
        {
            Wf.Ran(nameof(EmitConstantRecords));

        }
    }
}