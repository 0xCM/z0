//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using static MatchAddressesStep;

    public readonly struct MatchAddressesStep
    {
        public const string WorkerName = nameof(MatchAddresses);
    }
    
    public ref struct MatchAddresses
    {        
        readonly WfState Wf;
        
        readonly CorrelationToken Ct;

        readonly ExtractedCode[] Extracted;

        readonly AsmFunction[] Decoded;

        readonly ApiHostUri Host;

        public MatchAddresses(WfState wf, ApiHostUri host, ExtractedCode[] extracted, AsmFunction[] decoded, CorrelationToken ct)
        {
            Wf = wf;
            Host = host;
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
                Demands.insist(a.Count, Extracted.Length);

                var b = Decoded.Select(f => f.BaseAddress).ToHashSet();
                Demands.insist(b.Count, Decoded.Length);
                
                b.IntersectWith(a);
                Demands.insist(b.Count, Decoded.Length);                
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