//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct EmitCilRecords
    {
        readonly IWfPartEmission Wf;

        [MethodImpl(Inline)]
        public EmitCilRecords(IWfPartEmission wf)
        {
             Wf = wf;
        }

        public EmissionDataType StepKind 
            => EmissionDataType.Il;        

        public PartRecordKind DataKind
            => PartRecordKind.None;

        const string FieldDelimiter = "| ";
        
        public void Emit(IPart[] parts)
        {
            StepKind.Emitting(Wf);

            foreach(var part in parts)
            {
                var id = part.Id;
                var path = Wf.TargetPath(id, StepKind);
                StepKind.Emitting(path,Wf);

                var assembly = part.Owner;                
                var methods = PartReader.methods(FilePath.Define(assembly.Location));
                var count = methods.Length;
                
                using var writer = path.Writer();                
                writer.WriteLine(text.concat(FieldDelimiter, "Method".PadRight(50), FieldDelimiter, "Rva".PadRight(12), FieldDelimiter, "Il"));
                for(var i=0; i<count; i++)
                {
                    ref readonly var method = ref Root.skip(methods,i);
                    writer.WriteLine(text.concat(FieldDelimiter, method.Name.PadRight(50), FieldDelimiter, method.Rva.Format().PadRight(12), FieldDelimiter, method.Cil.Format()));
                }

                DataEmitters.emitted(Wf, DataKind, id, count);
            }                         

            StepKind.Emitted(Wf);
        }             
    }
}