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

    using MK = EmissionDataType;
    using MES = WfStatusKind;
    
    public readonly struct MetadataEmitter : IEmissionWorkflow
    {
        public FolderPath TargetDir {get;}

        public IAppContext Context {get;}
        
        readonly FolderPath ResRoot;
        
        readonly IPart[] Parts;

        readonly PartSink Sink;

        public WfKind WfKind
            => WfKind.MetadataEmission;
        
        public MetadataEmitter(IAppContext context)
        {            
            Context = context;
            ResRoot = AppPaths.Default.ResourceRoot;
            TargetDir = ResRoot + FolderName.Define("metadata");
            Parts = KnownParts.Service.Known.ToArray();
            Sink = new PartSink(context);
        }

        public void Deposit(IAppEvent src)
        {
            term.print(src);
            Sink.Deposit(src);
        }

        IEmissionWorkflow Wf 
            => this;

        IPartReader Reader(string src)
            => PartReader.open(FilePath.Define(src));

        FilePath TargetPath(PartId part, PartRecordKind rk, MK mk)
            => TargetDir +  PartDataEmitters.filename(mk, rk);

        FolderPath PrepareTarget()
        {            
            var target = TargetDir;
            PartDataEmitters.running(target,this);
            target.Create().Clear();
            PartDataEmitters.ran(target, this);            
            return target;
        }
        
        public void Emit()
        {
            WfKind.Status(MES.RunningWorkflow, this);
            
            PrepareTarget();            
            
            new EmitConstantRecords(this).Emit(Parts);

            {
                using var emitter = new EmitPeRecords(this, Parts, ResRoot + FileName.Define("z0", "pe.csv"));
                emitter.Run();
            }
            
            {
                using var emitter = new EmitCilRecords(this, Parts,  ResRoot + FolderName.Define("il"));
                emitter.Run();
            }

            {
                using var emitter = new EmitImageContent(this, Parts);
                emitter.Run();
            }
            
            {
                using var emitter = new EmitStringRecords(this, Parts, ResRoot + FolderName.Define("strings"));
                emitter.Run();
            }

            {
                using var emitter = new EmitBlobRecords(this, Parts, Wf.TargetDir);
                emitter.Run();
            }
        
            {
                using var emitter = new EmitFieldRecords(this, Parts, Wf.TargetDir);
                emitter.Run();
            }
                        
            WfKind.Status(MES.RanWorkflow, this);
        }        
    }
}