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
    
    public readonly ref struct EmitMetadataSets
    {
        public FolderPath TargetDir {get;}

        public readonly Wf Context;
        
        readonly FolderPath ResRoot;
        
        readonly IPart[] Parts;

        readonly PartSink Sink;

        public WfKind WfKind
            => WfKind.MetadataEmission;
        
        public EmitMetadataSets(Wf context)
        {            
            Context = context;
            ResRoot = AppPaths.Default.ResourceRoot;
            TargetDir = ResRoot + FolderName.Define("metadata");
            Parts = KnownParts.Service.Known.ToArray();
            Sink = new PartSink(context.ContextRoot);
            Context.Running(nameof(EmitMetadataSets));
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
            PartDataEmitters.running(target,Context.ContextRoot);
            target.Create().Clear();
            PartDataEmitters.ran(target, Context.ContextRoot);            
            return target;
        }
        
        public void Run()
        {
            var ct = Context.Running(nameof(EmitMetadataSets));
            
            PrepareTarget();            
            
            {
                using var emitter = new EmitConstantRecords(Context, Parts);
                emitter.Run();
            }

            {
                using var emitter = new EmitPeRecords(Context.ContextRoot, Parts);
                emitter.Run();
            }
            
            {
                using var emitter = new EmitCilRecords(Context.ContextRoot, Parts);
                emitter.Run();
            }

            {
                using var emitter = new EmitImageContent(Context.ContextRoot, Parts);
                emitter.Run();
            }
            
            {
                using var emitter = new EmitStringRecords(Context.ContextRoot, Parts);
                emitter.Run();
            }

            {
                using var emitter = new EmitBlobRecords(Context.ContextRoot, Parts);
                emitter.Run();
            }
        
            {
                using var emitter = new EmitFieldRecords(Context.ContextRoot, Parts);
                emitter.Run();
            }
                        
            Context.Ran(nameof(EmitMetadataSets),ct);
        }        

        public void Dispose()
        {
            Context.Ran(nameof(EmitMetadataSets));
        }
    }
}