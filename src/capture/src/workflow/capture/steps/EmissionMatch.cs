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
    using static CaptureWorkflowEvents;
    using static Memories;

    public readonly struct MatchEmissionsStep : IMatchEmissions
    {
        public ICaptureWorkflow Workflow {get;}

        public ICaptureContext Context 
            => Workflow.Context;

        [MethodImpl(Inline)]
        internal MatchEmissionsStep(ICaptureWorkflow workflow)
            => Workflow = workflow;

        ICheckEquatable Claim 
            => CheckEquatable.Checker;

        public void MatchEmissions(ApiHostUri host, ReadOnlySpan<IdentifiedCode> srcA, FilePath srcB)
        {                
            var wfStateless = Capture.Services;
            var reader = wfStateless.UriHexReader;
            var fileSrc = reader.Read(srcB).ToArray().ToSpan();                        

            Claim.eq(fileSrc.Length, srcA.Length);  
            Claim.eq(Spans.count<IdentifiedCode>(fileSrc, s => s.OpUri.IsEmpty),0);                          
            for(var i=0; i<srcA.Length; i++)
            {
                Claim.eq(skip(fileSrc,i).OpUri, skip(srcA,i).OpUri);  
                Claim.eq(skip(fileSrc,i).Encoded.Length, skip(srcA, i).Encoded.Length);
            }

            Context.Raise(new MatchedEmissions(host, srcA.Length, srcB));
        }
    }
}