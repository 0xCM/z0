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

    public readonly ref struct ExtractMembersStep
    {
        readonly CorrelationToken Ct;

        readonly CaptureState Wf;
        
        ICaptureWorkflow CWf 
             => Wf.CWf;

        public ICaptureContext Context 
            => CWf.Context;
        
        [MethodImpl(Inline)]
        public ExtractMembersStep(CaptureState state, CorrelationToken? ct = null)
        {
            Wf = state;
            Ct = correlate(ct);
            Wf.Initialized(nameof(ExtractMembersStep), Ct);
        }

        public void Dispose()
        {
            Wf.Finished(nameof(ExtractMembersStep), Ct);
        }

        ApiMember[] jit(IApiHost[] hosts)
            => ApiMemberJit.jit(hosts, Wf.AppEventSink);
        
        ExtractedCode[] Extract(ICaptureContext context, IApiHost host)
        {            
            var members = ApiMemberJit.jit(host);
            context.Raise(new MembersLocated(host.Uri, members));            
            return Extractor.Extract(members);
        }

        public ExtractedCode[] ExtractMembers(IApiHost host)
        {
            var extracted = sys.empty<ExtractedCode>();            
            try
            {
                extracted = Extract(Context,host); 
                Context.Raise(new ExtractedMembers(host.Uri, extracted.Length));
            }
            catch(Exception e)
            {
                Wf.Raise(new WorkflowError($"{host.Uri} extract failure", e));
            }
            return extracted;
        }
        
        public ExtractedCode[] ExtractMembers(IApiHost[] hosts)
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
                Context.Raise(new WorkflowError($"Extract failure", e));
                return sys.empty<ExtractedCode>();
            }            
        }

        static MemberExtractor Extractor
            => MemberExtraction.service(Extracts.DefaultBufferLength);    
    }
}