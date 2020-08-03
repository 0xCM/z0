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
    using static Flow;
    
    public readonly ref struct EmitMetadataSets
    {
        public readonly WfContext Wf;

        readonly CorrelationToken Ct;
        
        readonly FolderPath TargetRoot;
        
        readonly IPart[] Parts;

        readonly PartSink Sink;

        
        public EmitMetadataSets(WfContext context, CorrelationToken? ct = null)
        {            
            Wf = context;
            Ct = correlate(ct);
            TargetRoot = AppPaths.Default.ResourceRoot;
            Parts = KnownParts.Service.Known.ToArray();
            Sink = new PartSink(context.ContextRoot);
            Wf.Created(nameof(EmitMetadataSets), Ct);
        }
        
        public void Run()
        {
            Wf.Running(nameof(EmitMetadataSets), Ct);
                                    
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