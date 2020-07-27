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
        readonly IWfPartEmission Wf;

        readonly IPart[] Parts;
        
        readonly FieldRecord Spec;

        readonly FolderPath TargetDir;

        readonly EmissionDataType DataType;

        [MethodImpl(Inline)]
        public EmitFieldRecords(IWfPartEmission wf, FieldRecord spec, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            Spec = spec;
            TargetDir = wf.TargetDir;
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

        FilePath TargetPath(PartId part, PartRecordKind rk)
            => TargetDir +  DataType.FileName(rk);

        void Emit(IPart part)
        {
            var rk = Wf.DataTypes.FieldRva;
            var id = part.Id;
            var path = TargetPath(id, rk.Kind);
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