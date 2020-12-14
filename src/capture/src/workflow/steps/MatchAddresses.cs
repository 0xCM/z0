//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static z;

    ref struct MatchAddressesStep
    {
        readonly IWfCaptureState State;

        readonly IWfShell Wf;

        readonly ApiMemberExtract[] Extracted;

        readonly AsmRoutine[] Decoded;

        readonly WfHost Host;

        public MatchAddressesStep(IWfCaptureState state, WfHost host, ApiMemberExtract[] extracted, AsmRoutine[] decoded, CorrelationToken ct)
        {
            State = state;
            Wf =state.Wf;
            Host = host;
            Extracted = extracted;
            Decoded = decoded;
            Wf.Created(Host);
        }


        public void Dispose()
        {
           Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host, Seq.delimit(Extracted.Length, Decoded.Length));

            try
            {
                var a = Extracted.Select(x => x.Address).ToHashSet();
                if(a.Count != Extracted.Length)
                    Wf.Error(Host, $"count(Extracted) = {Extracted.Length} != {a.Count} = count(set(Extracted))");

                var b = Decoded.Select(f => f.BaseAddress).ToHashSet();
                if(b.Count != Decoded.Length)
                    Wf.Error(Host, $"count(Decoded) = {Decoded.Length} != {b.Count} = count(set(Decoded))");

                b.IntersectWith(a);
                if(b.Count != Decoded.Length)
                    Wf.Error(Host, $"count(Decoded) = {Decoded.Length} != {b.Count} = count(intersect(Decoded,Extracted))");

            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }

            Wf.Ran(Host, Seq.delimit(Extracted.Length, Decoded.Length));
        }
    }
}