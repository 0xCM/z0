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
    
    public readonly ref struct EmitMetadataSets
    {
        public FolderPath TargetDir {get;}

        readonly CorrelationToken Correlation;

        public readonly WfContext Wf;
        
        readonly FolderPath ResRoot;
        
        readonly IPart[] Parts;

        readonly PartSink Sink;

        public WfKind WfKind
            => WfKind.MetadataEmission;
        
        public EmitMetadataSets(WfContext context, CorrelationToken? ct = null)
        {            
            Wf = context;
            Correlation = ct ?? CorrelationToken.create();
            ResRoot = AppPaths.Default.ResourceRoot;
            TargetDir = ResRoot + FolderName.Define("metadata");
            Parts = KnownParts.Service.Known.ToArray();
            Sink = new PartSink(context.ContextRoot);
            Wf.Running(nameof(EmitMetadataSets), Correlation);
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
            PartDataEmitters.running(target,Wf.ContextRoot);
            target.Create().Clear();
            PartDataEmitters.ran(target, Wf.ContextRoot);            
            return target;
        }
        
        public void Run()
        {
            var ct = Wf.Running(nameof(EmitMetadataSets));
            
            PrepareTarget();            
            
            {
                using var emitter = new EmitConstantRecords(Wf, Parts);
                emitter.Run();
            }

            {
                using var emitter = new EmitPeRecords(Wf, Parts);
                emitter.Run();
            }
            
            {
                using var emitter = new EmitCilRecords(Wf, Parts);
                emitter.Run();
            }

            {
                using var emitter = new EmitImageContent(Wf, Parts);
                emitter.Run();
            }
            
            {
                using var emitter = new EmitStringRecords(Wf, Parts);
                emitter.Run();
            }

            {
                using var emitter = new EmitBlobRecords(Wf, Parts);
                emitter.Run();
            }
        
            {
                using var emitter = new EmitFieldRecords(Wf, Parts);
                emitter.Run();
            }
                        
            Wf.Ran(nameof(EmitMetadataSets),ct);
        }        

        public void Dispose()
        {
            Wf.Ran(nameof(EmitMetadataSets), Correlation);
        }
    }
}