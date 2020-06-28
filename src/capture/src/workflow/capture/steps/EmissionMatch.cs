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

        TCheckEquatable Claim 
            => CheckEquatable.Checker;

        public void MatchEmissions(ApiHostUri host, ReadOnlySpan<IdentifiedCode> srcA, FilePath srcB)
        {                
            var wfStateless = Capture.Services;
            var reader = wfStateless.EncodedHexReader;
            var fileSrc = reader.Read(srcB).ToArray().ToSpan();                        

            Claim.Eq(fileSrc.Length, srcA.Length);  
            Claim.Eq(Spans.count<IdentifiedCode>(fileSrc, s => s.OpUri.IsEmpty),0);                          
            for(var i=0; i<srcA.Length; i++)
            {
                Claim.Eq(skip(fileSrc,i).OpUri, skip(srcA,i).OpUri);  
                Claim.Eq(skip(fileSrc,i).Encoded.Length, skip(srcA, i).Encoded.Length);
            }

            Context.Raise(new MatchedEmissions(host, srcA.Length, srcB));
        }
    }
}