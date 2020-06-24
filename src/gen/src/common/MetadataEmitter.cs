//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
 
    using static Konst;
    using MetaSpecs = PartRecordSpecs;
    
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

            Emit(MetaSpecs.Strings);
            Emit(MetaSpecs.Blobs);
            Emit(MetaSpecs.Fields);
            Emit(MetaSpecs.Constants);
        }

        FilePath StringTarget(PartId part) 
            => TargetDir + FileName.Define($"{part}.{MetaSpecs.Strings}", Csv);

        FilePath BlobTarget(PartId part) 
            => TargetDir + FileName.Define($"{part}.{MetaSpecs.Blobs}", Csv);

        FilePath FieldTarget(PartId part) 
            => TargetDir + FileName.Define($"{part}.{MetaSpecs.Fields}", Csv);

        FilePath ConstantTarget(PartId part) 
            => TargetDir + FileName.Define($"{part}.{MetaSpecs.Constants}", Csv);

        FilePath EmissionTarget<K>(PartId part, K kind)
            where K : unmanaged, IPartRecordSpec
                => TargetDir + FileName.Define($"{part}.{kind.RecordType}", Csv);

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
        
        void Emit(StringValueSpec spec)
        {
            foreach(var part in Parts)
            {
                var assembly = part.Owner;
                using var reader = Reader(assembly.Location);
                var src = reader.ReadUserStrings();

                var dstPath = EmissionTarget(part.Id, spec);
                Emit(src, dstPath, spec);                
            }
        }

        void Emit(BlobSpec spec)
        {
            foreach(var part in Parts)
            {
                var assembly = part.Owner;
                using var reader = Reader(assembly.Location);
                var src = reader.ReadBlobs();

                var dstPath = EmissionTarget(part.Id, spec);
                Emit(src, dstPath, spec);                
            }
        }

        void Emit(FieldRecordSpec spec)
        {
            foreach(var part in Parts)
            {
                var assembly = part.Owner;
                using var reader = Reader(assembly.Location);
                var src = reader.ReadFields();

                var dstPath = EmissionTarget(part.Id, spec);
                Emit(src, dstPath, spec);                
            }
        }

        void Emit(ConstantRecordSpec spec)
        {
            foreach(var part in Parts)
            {
                var assembly = part.Owner;
                using var reader = Reader(assembly.Location);
                var src = reader.ReadConstants();

                var dstPath = EmissionTarget(part.Id, spec);
                Emit(src, dstPath, spec);                
            }
        }

        // void EmitBlobs()
        // {            
        //     var spec = MetaSpecs.Blobs;
        //     foreach(var part in Parts)
        //     {
        //         var assembly = part.Owner;
        //         var dstPath = BlobTarget(part.Id);
        //         var header = PartRecords.header(spec);

        //         using var reader = Reader(assembly.Location);
        //         var src = reader.ReadBlobs();
        //         if(src.Length != 0)
        //         {
        //             var dst = dstPath.Writer();
        //             dst.WriteLine(header);
        //             for(var i=0; i<src.Length; i++)
        //             {
        //                 ref readonly var value = ref Root.skip(src,i);
        //                 dst.WriteLine(value.Format());
        //             }
        //         }
        //     }
        // }

        // void EmitFields()
        // {            
        //     var spec = MetaSpecs.Fields;
        //     foreach(var part in Parts)
        //     {
        //         var assembly = part.Owner;
        //         var dstPath = FieldTarget(part.Id);
        //         var header = PartRecords.header(MetaSpecs.Fields);

        //         using var reader = Reader(assembly.Location);
        //         var src = reader.ReadFields();
        //         var dst = dstPath.Writer();
        //         dst.WriteLine(header);
        //         for(var i=0; i<src.Length; i++)
        //         {
        //             ref readonly var value = ref Root.skip(src,i);
        //             dst.WriteLine(value.Format());
        //         }
        //     }
        // }

        // void EmitConstants()
        // {            
        //     foreach(var part in Parts)
        //     {
        //         var assembly = part.Owner;
        //         var dstPath = ConstantTarget(part.Id);
        //         var header = PartRecords.header(MetaSpecs.Constants);

        //         using var reader = Reader(assembly.Location);
        //         var src = reader.ReadConstants();
        //         var dst = dstPath.Writer();
        //         dst.WriteLine(header);
        //         for(var i=0; i<src.Length; i++)
        //         {
        //             ref readonly var value = ref Root.skip(src,i);
        //             dst.WriteLine(value.Format());
        //         }
        //     }
        // }
    }
}