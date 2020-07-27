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
        
    public readonly ref struct EmitFieldRvaRecords
    {
        readonly IWfPartEmission Wf;

        readonly IPart[] Parts;
        
        readonly FieldRvaRecord Spec;

        readonly FolderPath TargetDir;

        readonly EmissionDataType DataType;

        public EmitFieldRvaRecords(IWfPartEmission wf, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            Spec = new PartRecordSpecs().FieldRva;
            TargetDir = wf.TargetDir;
            DataType = EmissionDataType.Rva;
            DataType.Emitting(wf);
        }

        FilePath TargetPath(PartId part)
            => TargetDir +  DataType.FileName(Spec.Kind);

        IPartReader Reader(string src)
            => PartReader.open(FilePath.Define(src));

        void Emit(IPart part)
        {
            var id = part.Id;
            var path = TargetPath(id);                
            
            Spec.Kind.Emitting(path,Wf);
            var assembly = part.Owner;                
            using var reader = Reader(assembly.Location);
            var src = reader.ReadFieldRva();
            var formatter = PartRecords.formatter(Spec);

            formatter.EmitHeader();
            Root.iter(src, record => record.Format(formatter));
            path.Ovewrite(formatter.Render()); 

            Spec.Kind.Emitted(id,Wf);
        }

        public void Run()
        {
            foreach(var part in Parts)
            {
                Emit(part);
            }
        }

        public void Dispose()
        {
            DataType.Emitting(Wf);
        }
    }
}