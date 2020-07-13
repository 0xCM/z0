//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct CilDataEmitter : IDataEmitter
    {
        readonly IMetadataWorkflow Workflow;

        [MethodImpl(Inline)]
        public CilDataEmitter(IMetadataWorkflow wf)
        {
            Workflow = wf;
        }

        public MetadataEmissionKind StepKind 
            => MetadataEmissionKind.Il;        

        public PartRecordKind DataKind
            => PartRecordKind.None;

        const string FieldDelimiter = "| ";
        
        public void Emit(IPart[] parts)
        {
            StepKind.Emitting(Workflow);

            foreach(var part in parts)
            {
                var id = part.Id;
                var path = Workflow.TargetPath(id, StepKind);
                StepKind.Emitting(path,Workflow);

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

                DataEmitters.emitted(Workflow, DataKind, id, count);
            }                         

            StepKind.Emitted(Workflow);
        }             
    }
}