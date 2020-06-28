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

        public ICaptureContext Context 
            => Workflow.Context;

        [MethodImpl(Inline)]
        internal ExtractMembersStep(ICaptureWorkflow workflow)
        {
            Workflow = workflow;
        }

        public static ApiMember[] locate(IApiHost host)
        {
            var locator = Identities.Services.ApiLocator;
            return locator.Located(host).ToArray();
        }

        public static ExtractedCode[] extract(IApiHost host)
        {            
            var members = locate(host);
            var extractor = MemberExtraction.service(Extracts.DefaultBufferLength);    
            return extractor.Extract(members);
        }
        
        public ApiMember[] LocateMembers(IApiHost host)
        {
            var located = locate(host);
            Context.Raise(new MembersLocated(host.Uri, located));              
            return located;
        }

        public ExtractedCode[] ExtractMembers(IApiHost host)
            => extract(host); 
    }
}