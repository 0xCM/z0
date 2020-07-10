//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    public readonly struct ExtractMembersStep : IExtractMembers
    {
        public ICaptureWorkflow Workflow {get;}

        static MemberLocator Locator => Identities.Services.ApiLocator;


        public ICaptureContext Context 
            => Workflow.Context;

        [MethodImpl(Inline)]
        internal ExtractMembersStep(ICaptureWorkflow workflow)
            => Workflow = workflow;

        static ApiMember[] locate(IApiHost host)
        {            
            var located = ApiMemberJit.jit(host);
            return located;
        }

        static MemberExtractor Extractor
            => MemberExtraction.service(Extracts.DefaultBufferLength);    
        
        static ExtractedCode[] extract(ICaptureContext context, IApiHost host)
        {            
            var members = locate(host);
            context.Raise(new MembersLocated(host.Uri, members));            
            return Extractor.Extract(members);
        }
        
        public ExtractedCode[] ExtractMembers(IApiHost host)
        {
            var extracted = Array.Empty<ExtractedCode>();            
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
    }
}