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

    public readonly ref struct EmitStringRecords
    {
        readonly IWfPartEmission Wf;

        readonly IPart[] Parts;
        
        [MethodImpl(Inline)]
        public EmitStringRecords(IWfPartEmission wf, params IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            StepKind.Emitting(Wf);
        }

        public EmissionDataType StepKind 
            => EmissionDataType.Strings;        

        public PartRecordKind DataKind
            => PartRecordKind.String;                

        public ReadOnlySpan<StringValueRecord> Read(IPart part)
        {
            var srcPath = Wf.PartPath(part);              
            using var reader = PartReader.open(srcPath);
            return reader.ReadStrings();        
        }
        
        void Emit(IPart part)
        {
            var id = part.Id;
            var dstPath = Wf.TargetPath(id, StepKind);

            DataKind.Emitting(dstPath, Wf);

            var data = Read(part);
            var count = data.Length;            
            var target = PartRecords.formatter(Wf.DataTypes.Strings);
            target.EmitHeader();
            for(var i=0u; i<count; i++)
                PartRecords.format(skip(data,i), target);

            using var writer = dstPath.Writer();
            writer.Write(target.Render());

            DataEmitters.emitted(Wf, DataKind, id, count);
        }

        public void Run()
        {
            foreach(var part in Parts)
                Emit(part);
        }

        public void Dispose()
        {
            StepKind.Emitted(Wf);
        }
    }
}