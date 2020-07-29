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
        
    public readonly ref struct EmitFieldRecords
    {    
        readonly IEmissionWorkflow Wf;

        readonly IPart[] Parts;
        
        readonly FieldRecord Spec;

        readonly FolderPath TargetDir;

        readonly EmissionDataType DataType;

        [MethodImpl(Inline)]
        public EmitFieldRecords(IEmissionWorkflow wf, IPart[] parts, FolderPath dst)
        {
            Wf = wf;
            Parts = parts;
            Spec = PartRecordSpecs.Fields;
            TargetDir = dst;
            DataType = EmissionDataType.Field;
            DataType.Emitting(Wf);
        }

        public void Run()
        {  
            foreach(var part in Parts)
                Emit(part);            
        }
        
        static IPartReader Reader(string src)
            => PartReader.open(FilePath.Define(src));

        FilePath TargetPath(PartId part)
            => TargetDir +  FileName.Define(part.Format(), "fields.csv");

        void Emit(IPart part)
        {
            var rk = PartRecordSpecs.FieldRva;
            var id = part.Id;
            var path = TargetPath(id);
            DataType.Emitting(path, Wf);

            var assembly = part.Owner;                
            using var reader = Reader(assembly.Location);
            var src = reader.ReadFields();

            var formatter = PartRecords.formatter(Spec);
            formatter.EmitHeader();

            Root.iter(src, record => record.Format(formatter));
            path.Ovewrite(formatter.Render());                

            rk.Kind.Emitted(id, Wf);
        }


        public void Dispose()
        {
            DataType.Emitted(Wf);                          
        }
    }
}