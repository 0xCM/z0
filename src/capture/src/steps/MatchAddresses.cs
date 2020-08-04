//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    public readonly ref struct MatchAddresses
    {
        public ICaptureWorkflow Workflow {get;}

        public ICaptureContext Context 
            => Workflow.Context;

        public MatchAddresses(ICaptureWorkflow workflow)
            => Workflow = workflow;
        
        public void Run(ApiHostUri host, ExtractedCode[] extracted, AsmFunction[] decoded)
        {
            try
            {
                var a = extracted.Select(x => x.Address).ToHashSet();
                Demands.insist(a.Count, extracted.Length);

                var b = decoded.Select(f => f.BaseAddress).ToHashSet();
                Demands.insist(b.Count, decoded.Length);
                
                b.IntersectWith(a);
                Demands.insist(b.Count, decoded.Length);                
            }
            catch(Exception e)
            {
                term.error(e,$"Addresses from {host} decoded functions do not match with the extract addresses");
            }
        }
        
        public void Dispose()
        {

        }
    }
}