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
     
    using static PartRecords;

    using MK = MetadataEmissionKind;
    using MES = EmissionStatusKind;
    

    public enum EmissionStatusKind : byte
    {
        None = 0,

        RunningWorkflow,

        RanWorkflow
    }

    public enum EmissionWorkflowKind : uint
    {
        None = 0,

        MetadataEmission
    }
    
    partial class XTend
    {
        [MethodImpl(Inline), Op]
        public static DateTime now()
            => DateTime.Now;

        [MethodImpl(Inline), Op]
        public static string format(DateTime src)
            => src.ToLexicalString();

        [MethodImpl(Inline), Op]
        public static string format(EmissionWorkflowKind kind)
        {
            return $"{kind}";
        }

        [MethodImpl(Inline), Op]
        public static string format(EmissionStatusKind status)
        {
            return $"{status}";
        }
        
        public static void Status(this EmissionWorkflowKind kind, EmissionStatusKind status, IAppEventSink dst)
        {            
            var ts = format(now());
            var info = text.concat(ts, Space, FieldDelimiter, Space, format(kind), Space, FieldDelimiter, Space, format(status));
            // var info = status switch{
            //     RunningWorkflow => $"{ts}    | {kind} execution started",
            //     RanWorkflow => $"{ts}    | {kind} execution finished",
            //     _ => $"Executing an unkinded step"
            // };

            dst.Deposit(Events.create($"{status}", info, StartFlair));
        }
        
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
            => dst.Deposit(Events.create($"{mk}_running", $"Emitting {mk} data files", StartFlair));

        public static void Emitting(this MK mk, FilePath path, IAppEventSink dst)
            => dst.Deposit(Events.create($"{mk}_running", $"{mk}: {path}", StartFlair));

        public static void Emitted(this MK mk, IAppEventSink dst)
            => dst.Deposit(Events.create($"{mk}_ran", $"Completed {mk} emission", EndFlair));

        public static void Emitting(this PartRecordKind rk,  FilePath path, IAppEventSink dst)
            => dst.Deposit(Events.create($"{rk}_running", $"{rk}: {path}", StartFlair));

        public static void Emitted(this PartRecordKind rk, PartId part, IAppEventSink dst)
            => dst.Deposit(Events.create($"{rk}_ran", $"Emitted {rk} {part.Format()} records", EndFlair));

        public static void Running(this FolderPath path, IAppEventSink dst)        
            => dst.Deposit(Events.create("prepare", $"Preparing archive {path}", StartFlair));

        public static void Ran(this FolderPath path, IAppEventSink dst)        
            => dst.Deposit(Events.create("prepared", $"Prepared archive {path}", EndFlair));

        public static void Ran(this MK mk, PartId part, FilePath path, IAppEventSink dst)
            => dst.Deposit(Events.create($"{mk}_{part}", $"Emitted {mk} {part.Format()} records to {path}", EndFlair));

        public static void Ran(this PartRecordKind rk, IAppEventSink dst)
            => dst.Deposit(Events.create($"{rk}_ran", $"Completed {rk} emission", EndFlair));

        public static void Ran(this MK mk, IAppEventSink dst)
            => dst.Deposit(Events.create($"{mk}_ran", $"Completed {mk} emission", EndFlair));
    }

    public readonly struct MetadataEmitter : IMetadataEmitters
    {
        public static MetadataEmitter Service(IAppContext context)
            => new MetadataEmitter(context);
        
        public FolderPath TargetDir {get;}

        public IAppContext Context {get;}
        
        readonly IPart[] Parts;

        readonly PartSink Sink;

        public EmissionWorkflowKind WfKind
            => EmissionWorkflowKind.MetadataEmission;
        
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

        IMetadataEmitters Wf 
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
        
        public void Emit()
        {
            WfKind.Status(MES.RunningWorkflow, this);
            
            PrepareTarget();            
            
            Wf.PeData.Emit(Parts);
            Wf.CilData.Emit(Parts);
            Wf.ConstantData.Emit(Parts);
            Wf.StringData.Emit(Parts);
            Wf.BlobData.Emit(Parts);
        
            Emit(Wf.DataTypes.Fields).Ran(this);
            Emit(Wf.DataTypes.FieldRva).Ran(this);            
            
            WfKind.Status(MES.RanWorkflow, this);
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
    }
}