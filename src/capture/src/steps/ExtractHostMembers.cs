//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ExtractHostMembersStep;

    [Step]
    public ref struct ExtractHostMembers
    {
        public WfState Wf {get;}

        readonly CorrelationToken Ct;
        
        readonly ApiHostUri Host;

        readonly IApiHost Source;

        
        public ExtractedCode[] Extractions;
                    
        [MethodImpl(Inline)]
        internal ExtractHostMembers(WfState state, IApiHost host, IPartCaptureArchive dst, CorrelationToken ct)
        {
            Wf = state;
            Ct = ct;
            
            Host = host.Uri;            
            Source = host;

            Extractions = new ExtractedCode[0]{};

            Wf.Created(WorkerName, Ct);            
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }
        
        public void Run()
        {
            Wf.Running(WorkerName, Ct);
            try
            {
                using var step = new ExtractMembers(Wf, Ct);
                Extractions = step.Extract(Source);
            }
            catch(Exception e)
            {
                Wf.Error(WorkerName, e, Ct);
            }

            Wf.Ran(WorkerName, Ct);
        }
    }
}