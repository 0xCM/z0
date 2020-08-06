//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    using static ExtractMembersStep;

    public readonly ref struct ExtractMembers
    {
        readonly CorrelationToken Ct;

        readonly WfState Wf;
        
        ICaptureWorkflow CWf 
             => Wf.CWf;

        public ICaptureContext Context 
            => CWf.Context;
        
        [MethodImpl(Inline)]
        public ExtractMembers(WfState state, CorrelationToken ct)
        {
            Wf = state;
            Ct = ct;
            Wf.Created(WorkerName,  Ct);
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }

        ApiMember[] jit(IApiHost[] hosts)
            => ApiMemberJit.jit(hosts, Wf.AppEventSink);
        
        ExtractedCode[] Extract(ICaptureContext context, IApiHost host)
        {            
            var members = ApiMemberJit.jit(host);
            context.Raise(new MembersLocated(host.Uri, members));            
            return Extractor.Extract(members);
        }

        public ExtractedCode[] Extract(IApiHost host)
        {
            var extracted = sys.empty<ExtractedCode>();            
            try
            {
                extracted = Extract(Context,host); 
                Context.Raise(new ExtractedMembers(host.Uri, extracted.Length));
            }
            catch(Exception e)
            {
                Wf.Raise(new WorkflowError(WorkerName, $"{host.Uri} extract failure", e, Ct));
            }
            return extracted;
        }
        
        public ExtractedCode[] Extract(IApiHost[] hosts)
        {
            var extracted = sys.empty<ExtractedCode>();            
            try
            {
                var members = ApiMemberJit.jit(hosts, Wf.WfEventSink);
                Wf.Raise(new JittedMembers(hosts, members));
                return Extractor.Extract(members);
            }
            catch(Exception e)
            {
                Wf.Raise(new WorkflowError(WorkerName, $"Extract failure", e, Ct));
                return sys.empty<ExtractedCode>();
            }            
        }

        static MemberExtractor Extractor
            => MemberExtraction.service(Extractors.DefaultBufferLength);    
    }
}