//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static MatchAddressesStep;
    
    public ref struct MatchAddresses
    {        
        readonly WfCaptureState Wf;
        
        readonly CorrelationToken Ct;

        readonly ExtractedCode[] Extracted;

        readonly AsmFunction[] Decoded;

        public MatchAddresses(WfCaptureState wf, ExtractedCode[] extracted, AsmFunction[] decoded, CorrelationToken ct)
        {
            Wf = wf;
            Extracted = extracted;
            Decoded = decoded;
            Ct = ct;
        }
        
        public void Run()
        {
            Wf.Running(StepName, Ct);
            try
            {
                var a = Extracted.Select(x => x.Address).ToHashSet();
                if(a.Count != Extracted.Length)
                    Wf.Error(StepName, $"count(Extracted) = {Extracted.Length} != {a.Count} = count(set(Extracted))", Ct);

                var b = Decoded.Select(f => f.BaseAddress).ToHashSet();
                if(b.Count != Decoded.Length)
                    Wf.Error(StepName, $"count(Decoded) = {Decoded.Length} != {b.Count} = count(set(Decoded))", Ct);
                
                b.IntersectWith(a);
                if(b.Count != Decoded.Length)
                    Wf.Error(StepName, $"count(Decoded) = {Decoded.Length} != {b.Count} = count(intersect(Decoded,Extracted))", Ct);
                               
            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);    
            }

            Wf.Ran(StepName, Ct);

        }
        
        public void Dispose()
        {
           Wf.Finished(StepName, Ct);
        }
    }
}