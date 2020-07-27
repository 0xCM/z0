//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static PartRecords;
    using static z;

    public readonly struct EmitConstantRecords
    {
        readonly IWfPartEmission Wf;
        
        [MethodImpl(Inline)]
        public EmitConstantRecords(IWfPartEmission wf)
        {
            Wf = wf;
        }

        public EmissionDataType StepKind 
            => EmissionDataType.Konst;        

        public PartRecordKind DataKind
            => PartRecordKind.Constant;
                
        public ReadOnlySpan<ConstantRecord> Read(IPart part)
        {
            var srcPath = Wf.PartPath(part);              
            using var reader = PartReader.open(srcPath);
            return reader.ReadConstants();        
        }
        
        public void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath = Wf.TargetPath(id, StepKind);

            DataKind.Emitting(dstPath, Wf);

            var data = Read(part);
            var count = data.Length;            
            var target = PartRecords.formatter(Wf.DataTypes.Constants);
            target.EmitHeader();
            for(var i=0u; i<count; i++)
                PartRecords.format(skip(data,i), target);

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            DataEmitters.emitted(Wf, DataKind, id, count);
        }
        
        public void Emit(IPart[] parts)
        {
            StepKind.Emitting(Wf);

            foreach(var part in parts)
                Emit(part);

            StepKind.Emitted(Wf);
        }
    }
}