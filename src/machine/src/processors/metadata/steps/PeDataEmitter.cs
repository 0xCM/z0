//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct PeDataEmitter : IDataEmitter
    {
        readonly IMetadataWorkflow Workflow;
        
        [MethodImpl(Inline)]
        public PeDataEmitter(IMetadataWorkflow wf)
        {
            Workflow = wf;
        }

        public MetadataEmissionKind StepKind 
            => MetadataEmissionKind.Pe;        

        public PartRecordKind DataKind
            => PartRecordKind.PeHeader;
        
        public void Emit(IPart[] parts)
        {
            StepKind.Emitting(Workflow);

            foreach(var part in parts)
            {
                var id = part.Id;
                var path = Workflow.TargetPath(id, StepKind);
                var assembly = part.Owner;                
                
                DataKind.Emitting(path,Workflow);

                var data = PartReader.headers(FilePath.Define(assembly.Location));
                var rendered = HeaderInfo.render(data);
                var count = rendered.Length;
                
                using var writer = path.Writer();
                for(var i=0; i<count; i++)
                    writer.WriteLine(Root.skip(rendered,i));

                DataEmitters.emitted(Workflow, DataKind, id, count);
            }  

            StepKind.Emitted(Workflow);                          
        }
    }
}