//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using System.Linq;
    using System.IO;
    using System.Reflection;
     
    using static PartRecords;

    using MK = MetadataEmissionKind;
    using MES = MetadataEmissionStep;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
                
    partial class XTend
    {
        const AppMsgColor StartFlair = AppMsgColor.Blue;


        const AppMsgColor EndFlair = AppMsgColor.Cyan;

        static FileExtension ExtX(this MK mk)
            => FileExtension.Define(mk switch {
                _ => mk.ToString().ToLower(),
            });

        public static FileExtension Ext(this MK mk)
            => FileExtension.Define($"{mk.ExtX()}.{FileExtensions.Csv}");

        public static FileName DataFileName(this MK mk, PartRecordKind rk)
            => FileName.Define($"{rk.ToString().ToLower()}", mk.Ext());
        
        public static void Emitting(this MK mk, IAppEventSink dst)
            => dst.Deposit(AppEvents.create($"{mk}_running", $"Emitting {mk} data files", StartFlair));

        public static void Emitting(this MK mk, FilePath path, IAppEventSink dst)
            => dst.Deposit(AppEvents.create($"{mk}_running", $"{mk}: {path}", StartFlair));

        public static void Emitted(this MK mk, IAppEventSink dst)
            => dst.Deposit(AppEvents.create($"{mk}_ran", $"Completed {mk} emission", EndFlair));

        public static void Emitting(this PartRecordKind rk,  FilePath path, IAppEventSink dst)
            => dst.Deposit(AppEvents.create($"{rk}_running", $"{rk}: {path}", StartFlair));

        public static void Emitted(this PartRecordKind rk, PartId part, IAppEventSink dst)
            => dst.Deposit(AppEvents.create($"{rk}_ran", $"Emitted {rk} {part.Format()} records", EndFlair));


        public static void Ran(this MES step, IAppEventSink dst,  [Caller] string caller = null)
        {
            var @this = MethodBase.GetCurrentMethod();
            var info = step switch{
                MES.RanWorkflow => $"Metadata emission workflow: ${@this.Name}",
                _ => $"Executing an unkinded step"
            };

            dst.Deposit(AppEvents.create($"{step}", info, StartFlair));            
        }

        public static void Running(this FolderPath path, IAppEventSink dst)        
            => dst.Deposit(AppEvents.create("prepare", $"Preparing archive {path}", StartFlair));

        public static void Ran(this FolderPath path, IAppEventSink dst)        
            => dst.Deposit(AppEvents.create("prepared", $"Prepared archive {path}", EndFlair));

        public static void Ran(this MK mk, PartId part, FilePath path, IAppEventSink dst)
            => dst.Deposit(AppEvents.create($"{mk}_{part}", $"Emitted {mk} {part.Format()} records to {path}", EndFlair));

        public static void Ran(this PartRecordKind rk, IAppEventSink dst)
            => dst.Deposit(AppEvents.create($"{rk}_ran", $"Completed {rk} emission", EndFlair));

        public static void Ran(this MK mk, IAppEventSink dst)
            => dst.Deposit(AppEvents.create($"{mk}_ran", $"Completed {mk} emission", EndFlair));
    }

    public readonly struct MetadataEmitter : IMetadataEmitter
    {
        public static MetadataEmitter Service(IAppContext context)
            => new MetadataEmitter(context);
        
        public FolderPath TargetDir {get;}

        public IAppContext Context {get;}
        
        readonly IPart[] Parts;

        readonly PartSink Sink;

        public MetadataEmitter(IAppContext context)
        {            
            Context = context;
            TargetDir = AppPaths.Default.ResourceRoot + FolderName.Define("metadata");
            Parts = KnownParts.Service.Known.ToArray();
            Sink = new PartSink(context);
        }

        public void Deposit(IAppEvent src)
        {
            term.print(src);
            Sink.Deposit(src);
        }

        IMetadataEmitter Wf 
            => this;

        IPartReader Reader(string src)
            => PartReader.open(FilePath.Define(src));

        FilePath TargetPath(PartId part, PartRecordKind rk, MK mk)
            => TargetDir +  mk.DataFileName(rk);

        FolderPath PrepareTarget()
        {            
            var target = TargetDir;
            target.Running(this);
            target.Create().Clear();
            target.Ran(this);            
            return target;
        }
        
        public void Emit(MES step = MES.RunningWorkflow)
        {
            step.Running(this);            
            PrepareTarget();            
            
            Wf.PeData.Emit(Parts);
            Wf.CilData.Emit(Parts);
            Wf.ConstantData.Emit(Parts);
            Wf.StringData.Emit(Parts);
        
            Emit(Wf.DataTypes.Blobs).Ran(this);
            Emit(Wf.DataTypes.Fields).Ran(this);
            Emit(Wf.DataTypes.FieldRva).Ran(this);            
            step.Ran(this);
        }
        

        PartRecordKind Emit(FieldRvaRecord spec, MK mk = MK.Rva)
        {
            var rk = spec.Kind;

            mk.Emitting(this);

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, rk, mk);                
                rk.Emitting(path,this);

                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadFieldRva();
                var formatter = PartRecords.formatter(spec);

                formatter.EmitHeader();
                Root.iter(src, record => record.Format(formatter));
                path.Ovewrite(formatter.Render()); 

                rk.Emitted(id, this);
            }
            return rk;
        }

        PartRecordKind Emit(BlobRecord spec, MK mk = MK.Blob)
        {
            var rk = spec.Kind;

            mk.Emitting(this);

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, rk, mk);
                rk.Emitting(path,this);

                var assembly = part.Owner;                                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadBlobs();

                var formatter = PartRecords.formatter(spec);
                formatter.EmitHeader();
                Root.iter(src, record => record.Format(formatter));
                path.Ovewrite(formatter.Render());                

                rk.Emitted(id, this);

            }
            return rk;
        }

        PartRecordKind Emit(FieldRecord spec, MK mk = MK.Field)
        {
            var rk = spec.Kind;

            mk.Emitting(this);

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, rk, mk);
                rk.Emitting(path,this);

                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadFields();

                var formatter = PartRecords.formatter(spec);
                formatter.EmitHeader();

                Root.iter(src, record => record.Format(formatter));
                path.Ovewrite(formatter.Render());                

                rk.Emitted(id, this);

            }
            return rk;
        }

        PartRecordKind Emit(ConstantRecord spec, MK mk = MK.Konst)
        {
            var rk = spec.Kind;
            mk.Emitting(this);

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = TargetPath(id, rk, mk);
                rk.Emitting(path,this);

                var assembly = part.Owner;                
                using var reader = Reader(assembly.Location);
                var src = reader.ReadConstants();

                var formatter = PartRecords.formatter(spec);
                formatter.EmitHeader();

                Root.iter(src, record => record.Format(formatter));
                path.Ovewrite(formatter.Render());                

                rk.Emitted(id, this);
            }
            
            return rk;
        }

    }
}