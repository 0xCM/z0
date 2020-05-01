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
    using static Memories;

    partial class HostCaptureSteps
    {
        public readonly struct EmissionMatchStep : IEmissionMatchStep
        {
            public ICaptureWorkflow Workflow {get;}

            public ICaptureContext Context => Workflow.Context;

            [MethodImpl(Inline)]
            internal EmissionMatchStep(ICaptureWorkflow workflow)
            {
                Workflow = workflow;
            }

            ICheckEquatable Claim => CheckEquatable.Checker;

            public void MatchEmissions(ApiHostUri host, ReadOnlySpan<UriBits> srcA, FilePath srcB)
            {                
                var wfStateless = AsmWorkflows.Stateless;
                var reader = wfStateless.UriBitsReader;
                var fileSrc = reader.Read(srcB).ToArray().ToSpan();                        

                Claim.eq(fileSrc.Length, srcA.Length);            
                Claim.eq(fileSrc.Count(s => s.Op.IsEmpty), 0);
                
                for(var i=0; i<srcA.Length; i++)
                {
                    Claim.eq(skip(fileSrc,i).Op, skip(srcA,i).Op);  
                    Claim.eq(skip(fileSrc,i).Bits.Length, skip(srcA, i).Bits.Length);
                }

                Context.Raise(MatchedEmissions.Define(host, srcA.Length, srcB));
            }
        }
    }
}