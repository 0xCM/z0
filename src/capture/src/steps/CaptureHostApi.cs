//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static Flow;
    
    using static CaptureHostApiStep;

    [Step(WfStepId.CaptureHostApi)]
    public readonly ref struct CaptureHostApi
    {
        public WfState Wf {get;}
        
        public ICaptureWorkflow CWf {get;}

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public static CaptureHostApi create(WfState state, CorrelationToken ct)
            => new CaptureHostApi(state, ct);
        
        [MethodImpl(Inline)]
        internal CaptureHostApi(WfState state, CorrelationToken ct)
        {
            Ct = ct;
            Wf = state;
            CWf = state.CWf;            
            Wf.Created(WorkerName, Ct);
        }


        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }
                
        public void Execute(IApiHost host, TPartCaptureArchive dst)
        {
            try
            {
                using var extract = new ExtractHostMembers(Wf, host, dst, Ct);
                extract.Run();

                using var emit = new EmitHostArtifacts(Wf, host.Uri, extract.Extractions, dst, Ct);
                emit.Run();            
            }
            catch(Exception e)
            {
                Wf.Error(WorkerName,e, Ct);
            }
        }      
    }
}