//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Reflection;
 
    using static Konst;
    
    using static PartRecords;

    using MK = MetadataEmissionKind;
    using MES = MetadataEmissionStep;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    
    public enum MetadataEmissionKind : byte
    {
        None = 0,

        Bytes,

        Pe,

        Konst,

        Blob,

        Strings,

        Rva,

        Field,
    }

    public enum EventTargetKind : byte
    {
        None = 0,

        Console,

        File
    }

    public enum MetadataEmissionStep : byte
    {
        None = 0,

        RunningWorkflow,


        RanWorkflow
    }

    partial class XTend
    {
        static char[] InvalidFileChars() 
            => Path.GetInvalidFileNameChars();

        static char[] InvalidPathChars() 
            => Path.GetInvalidPathChars();

        static FileExtension ExtX(this MK mk)
            => FileExtension.Define(mk switch {
                MK.Bytes => "bytes",
                _ => mk.ToString().ToLower(),
            });

        public static FileExtension Ext(this MK mk)
            => FileExtension.Define($"{mk.ExtX()}.{FileExtensions.Csv}");

        public static FileName DataFileName(this MK mk, PartRecordKind rk)
            => FileName.Define($"{rk.ToString().ToLower()}", mk.Ext());

        
        public static void Deposit(this AppMsg src, EventTargetKind dst = EventTargetKind.Console)
        {
            term.print(src);
        }
        
        public static void Running(this MK mk)
            => AppMsg.Colorize($"Emitting {mk} data files", AppMsgColor.Blue).Deposit();

        public static void Running(this MK mk, FilePath dst)
            => AppMsg.Colorize($"{mk}: {dst}", AppMsgColor.Blue).Deposit();

        public static void Running(this PartRecordKind rk, FilePath dst)
            => AppMsg.Colorize($"{rk}: {dst}", AppMsgColor.Blue).Deposit();

        public static void Running(this MES step)
        {
            var @this = MethodBase.GetCurrentMethod();
            var msg = step switch{
                MES.RunningWorkflow => $"Metadata emission workflow: ${@this.Name}",
                _ => $"Executing an unkinded step"
            };
        }

        public static void Ran(this MES step, [Caller] string caller = null)
        {
            var @this = MethodBase.GetCurrentMethod();
            var msg = step switch{
                MES.RanWorkflow => $"Metadata emission workflow: ${@this.Name}",
                _ => $"Executing an unkinded step"
            };
        }

        public static void Running(this FolderPath dst)        
            => AppMsg.Colorize($"Preparing archive {dst}", AppMsgColor.Blue).Deposit();

        public static void Ran(this FolderPath dst)        
            => AppMsg.Colorize($"Prepared archive {dst}", AppMsgColor.Cyan).Deposit();

        public static void Ran(this PartRecordKind rk, PartId part)
            => AppMsg.Colorize($"Emitted {rk} {part.Format()} records", AppMsgColor.Cyan).Deposit();

        public static void Ran(this MK mk, PartId part, FilePath dst)
            => AppMsg.Colorize($"Emitted {mk} {part.Format()} records to {dst}", AppMsgColor.Cyan).Deposit();

        public static void Ran(this PartRecordKind rk)
            => AppMsg.Colorize($"Completed {rk} emission", AppMsgColor.Cyan).Deposit();

        public static void Ran(this MK mk)
            => AppMsg.Colorize($"Completed {mk} emission", AppMsgColor.Cyan).Deposit();

    }

    public readonly struct MetadataEmitter
    {

        public static MetadataEmitter Service()
            => new MetadataEmitter(0);
        
        readonly FolderPath TargetDir {get;}                     

        readonly IPart[] Parts;

        public MetadataEmitter(int i)
        {            
            TargetDir = AppPaths.Default.ResourceRoot + FolderName.Define("metadata");
            Parts = KnownParts.Service.Known.ToArray();
        }

        FilePath TargetPath(PartId part, MK kind)
            => TargetDir + FileName.Define(part.Format(), kind.Ext());

        IPartReader Reader(string src)
            => PartReader.open(FilePath.Define(src));

        FilePath TargetPath(PartId part, PartRecordKind rk, MK mk)
            => TargetDir +  mk.DataFileName(rk);


        FolderPath PrepareTarget()
        {            
            var target = TargetDir;
            target.Running();
            target.Create().Clear();
            target.Ran();            
            return target;
        }
        
        public void Emit(MES step = MES.RunningWorkflow)
        {
            step.Running();
            
            PrepareTarget();            
            EmitMethods().Ran();
            EmitPeHeaderInfo().Ran();
            Emit(PartRecordSpecs.Strings).Ran();
            Emit(PartRecordSpecs.Blobs).Ran();
            Emit(PartRecordSpecs.Fields).Ran();
            Emit(PartRecordSpecs.Constants).Ran();
            Emit(PartRecordSpecs.FieldRva).Ran();
            
            step.Ran();
        }
        
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
                    writer.WriteLine(value.Format(Chars.Pipe));
                }
            }
        }

        PartRecordKind Emit(StringValueRecord spec, MK mk = MK.Konst)
        {
            var rk = spec.Kind;

            mk.Running();

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, rk, mk);
                rk.Running(path);

                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadUserStrings();

                var formatter = PartRecords.formatter(spec);

                formatter.EmitHeader();
                Root.iter(src, record => record.Format(formatter));
                path.Ovewrite(formatter.Render());  
                
                rk.Ran(id);
            }
            
            return rk;
        }

        PartRecordKind Emit(FieldRvaRecord spec, MK mk = MK.Rva)
        {
            var rk = spec.Kind;

            mk.Running();

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, rk, mk);                
                rk.Running(path);

                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadFieldRva();
                var formatter = PartRecords.formatter(spec);

                formatter.EmitHeader();
                Root.iter(src, record => record.Format(formatter));
                path.Ovewrite(formatter.Render()); 

                rk.Ran(id);               
            }
            return rk;
        }

        PartRecordKind Emit(BlobRecord spec, MK mk = MK.Blob)
        {
            var rk = spec.Kind;

            mk.Running();

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, rk, mk);
                rk.Running(path);

                var assembly = part.Owner;                                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadBlobs();

                var formatter = PartRecords.formatter(spec);
                formatter.EmitHeader();
                Root.iter(src, record => record.Format(formatter));
                path.Ovewrite(formatter.Render());                

                rk.Ran(id);               

            }
            return rk;
        }

        PartRecordKind Emit(FieldRecord spec, MK mk = MK.Field)
        {
            var rk = spec.Kind;

            mk.Running();

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, rk, mk);
                rk.Running(path);

                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadFields();

                var formatter = PartRecords.formatter(spec);
                formatter.EmitHeader();

                Root.iter(src, record => record.Format(formatter));
                path.Ovewrite(formatter.Render());                

                rk.Ran(id);               

            }
            return rk;
        }

        PartRecordKind Emit(ConstantRecord spec, MK mk = MK.Konst)
        {
            var rk = spec.Kind;
            mk.Running();

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, rk, mk);
                rk.Running(path);

                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadConstants();

                var formatter = PartRecords.formatter(spec);
                formatter.EmitHeader();

                Root.iter(src, record => record.Format(formatter));
                path.Ovewrite(formatter.Render());                

                rk.Ran(id);               
            }
            
            return rk;
        }


        const string FieldDelimiter = "| ";
        
        MK EmitMethods(MK mk = MK.Bytes)
        {
            mk.Running();

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, mk);
                mk.Running(path);

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

                mk.Ran(id, path);
            } 
            
            return mk;                   
        }

        PartRecordKind EmitPeHeaderInfo(MK mk = MK.Pe)
        {
            var rk = PartRecordKind.PeHeader;
            mk.Running();

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, mk);
                rk.Running(path);

                var assembly = part.Owner;                
                var headers = PartReader.headers(FilePath.Define(assembly.Location));

                var rendered = HeaderInfo.render(headers);
                
                using var writer = path.Writer();
                for(var i=0; i<rendered.Length; i++)
                    writer.WriteLine(Root.skip(rendered,i));
            }                    

            return rk;
       }
    }
}