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
    
    public readonly ref struct MetadataEmitter
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
            Context.Running(nameof(MetadataEmitter));
        }

        public void Deposit(IAppEvent src)
        {
            term.print(src);
            Sink.Deposit(src);
        }

        IPartReader Reader(string src)
            => PartReader.open(FilePath.Define(src));

        FilePath TargetPath(PartId part, PartRecordKind rk, MK mk)
            => TargetDir +  PartDataEmitters.filename(mk, rk);

        FolderPath PrepareTarget()
        {            
            var target = TargetDir;
            PartDataEmitters.running(target,Context);
            target.Create().Clear();
            PartDataEmitters.ran(target, Context);            
            return target;
        }
        
        public void Emit()
        {
            WfKind.Status(MES.RunningWorkflow, Context);
            
            PrepareTarget();            
            
            {
                using var emitter = new EmitConstantRecords(Context, Parts);
                emitter.Run();
            }

            {
                using var emitter = new EmitPeRecords(Context, Parts);
                emitter.Run();
            }
            
            {
                using var emitter = new EmitCilRecords(Context, Parts);
                emitter.Run();
            }

            {
                using var emitter = new EmitImageContent(Context, Parts);
                emitter.Run();
            }
            
            {
                using var emitter = new EmitStringRecords(Context, Parts);
                emitter.Run();
            }

            {
                using var emitter = new EmitBlobRecords(Context, Parts);
                emitter.Run();
            }
        
            {
                using var emitter = new EmitFieldRecords(Context, Parts);
                emitter.Run();
            }
                        
            WfKind.Status(MES.RanWorkflow, Context);
        }        

        public void Dispose()
        {
            Context.Ran(nameof(MetadataEmitter));
        }
    }
}