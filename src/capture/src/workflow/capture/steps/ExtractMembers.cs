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

    using static Seed;
    using static CaptureWorkflowEvents;

    partial class HostCaptureSteps
    {
        public readonly struct ExtractMembersStep : IExtractMembersStep
        {
            public ICaptureWorkflow Workflow {get;}

            public ICaptureContext Context => Workflow.Context;

            [MethodImpl(Inline)]
            internal ExtractMembersStep(ICaptureWorkflow workflow)
            {
                Workflow = workflow;
            }
 
            public Member[] LocateMembers(IApiHost host)
            {
                var locator = Identities.Services.ApiLocator;
                var located = locator.Located(host).ToArray();
                Context.Raise(MembersLocated.Define(host.UriPath, located));              
                return located;
            }

            public ExtractedMember[] ExtractMembers(IApiHost host)
            {
                var members = LocateMembers(host);    
                var extractor = Capture.Services.HostExtractor();
                return extractor.Extract(members);
            }
        }
    }
}