//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public readonly ref struct EmitFieldRecords
    {    
        readonly WfContext Wf;

        readonly IPart[] Parts;
        
        readonly ImgFieldRecord Spec;

        readonly FolderPath TargetDir;

        readonly EmissionDataType DataType;

        [MethodImpl(Inline)]
        public EmitFieldRecords(WfContext wf, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            Spec = PartRecordSpecs.Fields;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("fields");
            DataType = EmissionDataType.Field;
            Wf.Running(nameof(EmitFieldRecords));
        }

        public void Run()
        {  
            foreach(var part in Parts)
                Emit(part);            
        }
        
        static IImgMetadataReader Reader(string src)
            => ImgMetadataReader.open(FilePath.Define(src));

        FilePath TargetPath(PartId part)
            => TargetDir +  FileName.Define(part.Format(), "fields.csv");

        void Emit(IPart part)
        {
            var rk = PartRecordSpecs.FieldRva;
            var id = part.Id;
            var path = TargetPath(id);

            Wf.Emitting(rk.ToString(), path);

            var assembly = part.Owner;                
            using var reader = Reader(assembly.Location);
            var src = reader.ReadFields();

            var formatter = PartRecords.formatter(Spec);
            formatter.EmitHeader();
            foreach(var record in src)
                PartRecords.format(record, formatter);

            //Root.iter(src, record => record.Format(formatter));
            path.Ovewrite(formatter.Render());                
            Wf.Emitted(rk.ToString(), (uint)src.Length, path);
        }


        public void Dispose()
        {
            Wf.Ran(nameof(EmitFieldRecords));
        }
    }
}