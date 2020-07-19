//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ExtractMembersStep : IExtractMembers
    {
        public ICaptureWorkflow Workflow {get;}

        public ICaptureContext Context 
            => Workflow.Context;

        [MethodImpl(Inline)]
        internal ExtractMembersStep(ICaptureWorkflow workflow)
            => Workflow = workflow;

        public static ApiMember[] jit(IApiHost host)
            => ApiMemberJit.jit(host);

        public static ApiMember[] jit(IApiHost[] hosts, IEventBroker broker)
            => ApiMemberJit.jit(hosts, broker);
        
        public static ExtractedCode[] extract(ICaptureContext context, IApiHost host)
        {            
            var members = jit(host);
            context.Raise(new MembersLocated(host.Uri, members));            
            return Extractor.Extract(members);
        }

        public static ExtractedCode[] extract(ICaptureContext context, IApiHost[] hosts, IEventBroker broker)
        {
            var members = jit(hosts, broker);
            context.Raise(new JittedMembers(hosts, members));
            var code = Extractor.Extract(members);
            return code;
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

        void OnStatus(IAppEvent e)
            => Context.Raise(e);
        
        public ExtractedCode[] ExtractMembers(IApiHost[] hosts)
        {
            var extracted = sys.empty<ExtractedCode>();            
            try
            {
                extracted = extract(Context,hosts, Context.Broker); 
            }
            catch(Exception e)
            {
                Context.Raise(new WorkflowError($"Extract failure", e));
            }
            return extracted;
        }

        static MemberExtractor Extractor
            => MemberExtraction.service(Extracts.DefaultBufferLength);    
    }
}