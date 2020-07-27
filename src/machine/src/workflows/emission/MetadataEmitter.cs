//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;     
    using static PartRecords;

    using MK = EmissionDataType;
    using MES = WfStatusKind;
    
    public readonly struct MetadataEmitter : IWfMetadatEmission
    {
        public static MetadataEmitter create(IAppContext context)
            => new MetadataEmitter(context);
        
        public FolderPath TargetDir {get;}

        public IAppContext Context {get;}
        
        readonly IPart[] Parts;

        readonly PartSink Sink;

        public WfKind WfKind
            => WfKind.MetadataEmission;
        
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

        IWfMetadatEmission Wf 
            => this;

        IPartReader Reader(string src)
            => PartReader.open(FilePath.Define(src));

        FilePath TargetPath(PartId part, PartRecordKind rk, MK mk)
            => TargetDir +  mk.FileName(rk);

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
            
            new EmitPeRecords(this).Emit(Parts);
            new EmitCilRecords(this).Emit(Parts);
            new EmitConstantRecords(this).Emit(Parts);
            
            {
                using var emitter = new EmitPartHexFiles(this, Parts);
                emitter.Run();
            }
            
            {
                using var emitter = new EmitStringRecords(this, Parts);
                emitter.Run();
            }

            {
                using var emitter = new EmitBlobRecords(this, Parts);
                emitter.Run();
            }
        
            {
                using var emitter = new EmitFieldRecords(this, Wf.DataTypes.Fields, Parts);
                emitter.Run();
            }
            
            {
                using var emitter = new EmitFieldRecords(this, Wf.DataTypes.Fields, Parts);
            }
         
            
            WfKind.Status(MES.RanWorkflow, this);
        }
        
        // PartRecordKind Emit(FieldRvaRecord spec, MK mk = MK.Rva)
        // {
        //     var rk = spec.Kind;

        //     mk.Emitting(this);

        //     foreach(var part in Parts)
        //     {
        //         var id = part.Id;
        //         var path = TargetPath(id, rk, mk);                
        //         rk.Emitting(path, this);

        //         var assembly = part.Owner;                
        //         using var reader = Reader(assembly.Location);
        //         var src = reader.ReadFieldRva();
        //         var formatter = PartRecords.formatter(spec);

        //         formatter.EmitHeader();
        //         Root.iter(src, record => record.Format(formatter));
        //         path.Ovewrite(formatter.Render()); 

        //         rk.Emitted(id, this);
        //     }
        //     return rk;
        // }
    }
}