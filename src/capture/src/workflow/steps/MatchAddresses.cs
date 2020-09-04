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
        readonly IWfCaptureState State;

        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly X86MemberExtract[] Extracted;

        readonly AsmRoutine[] Decoded;

        public MatchAddresses(IWfCaptureState state, X86MemberExtract[] extracted, AsmRoutine[] decoded, CorrelationToken ct)
        {
            State = state;
            Wf =state.Wf;
            Extracted = extracted;
            Decoded = decoded;
            Ct = ct;
        }

        public void Run()
        {
            Wf.Running(StepId, Ct);
            try
            {
                var a = Extracted.Select(x => x.Address).ToHashSet();
                if(a.Count != Extracted.Length)
                    Wf.Error(StepId, $"count(Extracted) = {Extracted.Length} != {a.Count} = count(set(Extracted))");

                var b = Decoded.Select(f => f.BaseAddress).ToHashSet();
                if(b.Count != Decoded.Length)
                    Wf.Error(StepId, $"count(Decoded) = {Decoded.Length} != {b.Count} = count(set(Decoded))");

                b.IntersectWith(a);
                if(b.Count != Decoded.Length)
                    Wf.Error(StepId, $"count(Decoded) = {Decoded.Length} != {b.Count} = count(intersect(Decoded,Extracted))");

            }
            catch(Exception e)
            {
                Wf.Error(StepId, e);
            }

            Wf.Ran(StepId);

        }

        public void Dispose()
        {
           Wf.Disposed(StepId);
        }
    }
}