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

        readonly CorrelationToken Ct;

        public readonly WfContext Wf;
        
        readonly FolderPath ResRoot;
        
        readonly IPart[] Parts;

        readonly PartSink Sink;

        public WfKind WfKind
            => WfKind.MetadataEmission;
        
        public EmitMetadataSets(WfContext context, CorrelationToken? ct = null)
        {            
            Wf = context;
            Ct = ct ?? CorrelationToken.create();
            ResRoot = AppPaths.Default.ResourceRoot;
            TargetDir = ResRoot + FolderName.Define("metadata");
            Parts = KnownParts.Service.Known.ToArray();
            Sink = new PartSink(context.ContextRoot);
            Wf.Created(nameof(EmitMetadataSets), Ct);
        }

        public void Deposit(IAppEvent src)
        {
            term.print(src);
            Sink.Deposit(src);
        }

        IImgMetadataReader Reader(string src)
            => ImgMetadataReader.open(FilePath.Define(src));

        FilePath TargetPath(PartId part, ImgRecordKind rk, MK mk)
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
            Wf.Running(nameof(EmitMetadataSets), Ct);
            
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
                using var emitter = new EmitBlobRecords(Wf, Ct, Parts);
                emitter.Run();
            }
        
            {
                using var emitter = new EmitFieldRecords(Wf, Parts);
                emitter.Run();
            }
                        
            Wf.Ran(nameof(EmitMetadataSets), Ct);
        }        

        public void Dispose()
        {
            Wf.Finished(nameof(EmitMetadataSets), Ct);
        }
    }
}