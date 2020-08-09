//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using static MatchAddressesStep;
    
    public ref struct MatchAddresses
    {        
        readonly WfState Wf;
        
        readonly CorrelationToken Ct;

        readonly ExtractedCode[] Extracted;

        readonly AsmFunction[] Decoded;

        public MatchAddresses(WfState wf, ExtractedCode[] extracted, AsmFunction[] decoded, CorrelationToken ct)
        {
            Wf = wf;
            Extracted = extracted;
            Decoded = decoded;
            Ct = ct;
        }
        
        public void Run()
        {
            Wf.Running(WorkerName, Ct);
            try
            {
                var a = Extracted.Select(x => x.Address).ToHashSet();
                if(a.Count != Extracted.Length)
                    Wf.Error(WorkerName, $"count(Extracted) = {Extracted.Length} != {a.Count} = count(set(Extracted))", Ct);

                var b = Decoded.Select(f => f.BaseAddress).ToHashSet();
                if(b.Count != Decoded.Length)
                    Wf.Error(WorkerName, $"count(Decoded) = {Decoded.Length} != {b.Count} = count(set(Decoded))", Ct);
                
                b.IntersectWith(a);
                if(b.Count != Decoded.Length)
                    Wf.Error(WorkerName, $"count(Decoded) = {Decoded.Length} != {b.Count} = count(intersect(Decoded,Extracted))", Ct);
                               
            }
            catch(Exception e)
            {
                Wf.Error(WorkerName, e, Ct);    
            }

            Wf.Ran(WorkerName, Ct);

        }
        
        public void Dispose()
        {
           Wf.Finished(WorkerName, Ct);
        }
    }
}