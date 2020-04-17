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
    using static AsmEvents;

    partial class HostCaptureSteps
    {
        public readonly struct ExtractMembers
        {
            readonly CaptureWorkflowContext Context;

            [MethodImpl(Inline)]
            internal static ExtractMembers Create(CaptureWorkflowContext context)
                => new ExtractMembers(context);
            
            [MethodImpl(Inline)]
            ExtractMembers(CaptureWorkflowContext context)
            {
                this.Context = context;
            }
 
            public ApiMember[] Members(in ApiHost host)
            {
                var locator = Context.MemberLocator();  
                var located = locator.Located(host).ToArray();
                Context.Raise(HostMembersLocated.Define(host, located));              
                return located;
            }

            public ApiMemberExtract[] Extracts(in ApiHost host)
            {
                var members = Members(host);    
                var extractor = Context.HostExtractor();
                return extractor.Extract(members);
            }
        }
    }
}