//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly ref struct ExtractMembersStep
    {
        public static ExtractMembersStep create(CaptureState state)
            => new ExtractMembersStep(state);
                
        readonly CaptureState State;
        
        ICaptureWorkflow CWf 
             => State.CWf;

        public ICaptureContext Context 
            => CWf.Context;

        public void Dispose()
        {

        }
        
        [MethodImpl(Inline)]
        internal ExtractMembersStep(CaptureState state)
        {
            State = state;
        }

        ApiMember[] jit(IApiHost host)
            => ApiMemberJit.jit(host);

        ApiMember[] jit(IApiHost[] hosts)
            => ApiMemberJit.jit(hosts, State.AppEventSink);
        
        ExtractedCode[] extract(ICaptureContext context, IApiHost host)
        {            
            var members = jit(host);
            context.Raise(new MembersLocated(host.Uri, members));            
            return Extractor.Extract(members);
        }

        public ExtractedCode[] ExtractMembers(IApiHost host)
        {
            var extracted = sys.empty<ExtractedCode>();            
            try
            {
                extracted = extract(Context,host); 
                Context.Raise(new ExtractedMembers(host.Uri, extracted.Length));
            }
            catch(Exception e)
            {
                Context.Raise(new WorkflowError($"{host.Uri} extract failure", e));
            }
            return extracted;
        }
        
        public ExtractedCode[] ExtractMembers(IApiHost[] hosts)
        {
            var extracted = sys.empty<ExtractedCode>();            
            try
            {
                var members = jit(hosts);
                State.Raise(new JittedMembers(hosts, members));
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