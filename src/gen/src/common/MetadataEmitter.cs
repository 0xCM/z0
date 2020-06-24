//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
 
    using static Konst;
    
    using static PartRecords;


    public readonly struct MetadataEmitter
    {
        public static MetadataEmitter Service(FolderPath dst = null)
            => new MetadataEmitter(dst);
        
        readonly FolderPath TargetDir {get;}                     

        readonly IPart[] Parts;

        public MetadataEmitter(FolderPath dst)
        {            
            TargetDir = dst ?? (AppPaths.Default.ResourceRoot + FolderName.Define("metadata"));
            Parts = KnownParts.Service.Known.ToArray();
        }

        IPartReader Reader(string src)
            => PartReader.open(FilePath.Define(src));
        
        FileExt Csv => FileExtA.Csv;
                
        public void Emit()
        {
            TargetDir.Clear();

            EmitMethods();
            EmitPeHeaderInfo();
            Emit(PartRecordSpecs.Strings);
            Emit(PartRecordSpecs.Blobs);
            Emit(PartRecordSpecs.Fields);
            Emit(PartRecordSpecs.Constants);
            Emit(PartRecordSpecs.FieldRva);
        }


        FilePath EmissionTarget<R>(PartId part, R r = default)
            where R : struct, IPartRecord
                => TargetDir + FileName.Define($"{part}.{r.Kind}", Csv);

        static void Emit<R,K>(ReadOnlySpan<R> src, FilePath dst, K k =default)
            where R : struct, IPartRecord<K>
            where K : unmanaged, IPartRecordSpec
        {
            if(src.Length != 0)
            {                
                var header = PartRecords.header<K>();
                var writer = dst.Writer();
                writer.WriteLine(header);
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var value = ref Root.skip(src,i);
                    writer.WriteLine(value.Format(FieldDelimiter));
                }
            }
        }
        
        void Emit(StringValueRecord spec)
        {
            foreach(var part in Parts)
            {
                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadUserStrings();

                var dst = PartRecords.formatter(spec);
                dst.EmitHeader();
                Root.iter(src, record => record.Format(dst));
                EmissionTarget(part.Id, spec).Ovewrite(dst.Render());                
            }
        }

        void Emit(FieldRvaRecord spec)
        {
            foreach(var part in Parts)
            {
                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadFieldRva();
                var dst = PartRecords.formatter(spec);
                dst.EmitHeader();
                Root.iter(src, record => record.Format(dst));
                EmissionTarget(part.Id, spec).Ovewrite(dst.Render());                
            }
        }

        void Emit(BlobRecord spec)
        {
            foreach(var part in Parts)
            {
                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadBlobs();

                var dst = PartRecords.formatter(spec);
                dst.EmitHeader();
                Root.iter(src, record => record.Format(dst));
                EmissionTarget(part.Id, spec).Ovewrite(dst.Render());                
            }
        }

        void Emit(FieldRecord spec)
        {
            foreach(var part in Parts)
            {
                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadFields();

                var dst = PartRecords.formatter(spec);
                dst.EmitHeader();
                Root.iter(src, record => record.Format(dst));
                EmissionTarget(part.Id, spec).Ovewrite(dst.Render());                
            }
        }

        void Emit(ConstantRecord spec)
        {
            foreach(var part in Parts)
            {
                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadConstants();

                var dst = PartRecords.formatter(spec);
                dst.EmitHeader();
                Root.iter(src, record => record.Format(dst));
                EmissionTarget(part.Id, spec).Ovewrite(dst.Render());                
            }
        }

        void EmitMethods()
        {
            const string Sep = "| ";
            foreach(var part in Parts)
            {
                var assembly = part.Owner;                
                var methods = PartReader.methods(FilePath.Define(assembly.Location));
                var count = methods.Length;
                var dst = TargetDir + FileName.Define($"{part}.Methdods", Csv);
                using var writer = dst.Writer();
                writer.WriteLine(text.concat(Sep, "Method".PadRight(50), Sep, "Rva".PadRight(12), Sep, "Il"));
                for(var i=0; i<count; i++)
                {
                    ref readonly var method = ref Root.skip(methods,i);
                    writer.WriteLine(text.concat(Sep, method.Name.PadRight(50), Sep, method.Rva.Format().PadRight(12), Sep, method.Cil.Format()));
                }
            }                    
        }

        void EmitPeHeaderInfo()
        {
            const string Sep = "| ";
            foreach(var part in Parts)
            {
                var assembly = part.Owner;                
                var headers = PartReader.headers(FilePath.Define(assembly.Location));
                var dst = TargetDir + FileName.Define($"{part.Id}.Headers", Csv);
                var rendered = HeaderInfo.render(headers);
                
                using var writer = dst.Writer();
                for(var i=0; i<rendered.Length; i++)
                    writer.WriteLine(Root.skip(rendered,i));
            }                    
        }
    }
}