//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct EmitPeRecords
    {
        readonly IWfPartEmission Wf;
        
        [MethodImpl(Inline)]
        public EmitPeRecords(IWfPartEmission wf)
        {
            Wf = wf;
        }

        public EmissionDataType StepKind 
            => EmissionDataType.Pe;        

        public PartRecordKind DataKind
            => PartRecordKind.PeHeader;
        
        public void Emit(IPart[] parts)
        {
            StepKind.Emitting(Wf);

            foreach(var part in parts)
            {
                var id = part.Id;
                var path = Wf.TargetPath(id, StepKind);
                var assembly = part.Owner;                
                
                PartDataEmitters.emitting(DataKind, path, Wf);

                var data = PartReader.headers(FilePath.Define(assembly.Location));
                var rendered = HeaderInfo.render(data);
                var count = rendered.Length;
                
                using var writer = path.Writer();
                for(var i=0; i<count; i++)
                    writer.WriteLine(Root.skip(rendered,i));

                DataEmitters.emitted(Wf, DataKind, id, count);
            }  

            StepKind.Emitted(Wf);                          
        }
    }
}