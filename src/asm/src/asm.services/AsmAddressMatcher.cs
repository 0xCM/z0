//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public class AsmAddressMatcher : WfService<AsmAddressMatcher>
    {
        public void Match(ApiMemberExtract[] extracted, AsmRoutine[] decoded)
        {
            try
            {
                var flow = Wf.Running(Seq.delimit(extracted.Length, decoded.Length));
                var a = extracted.Select(x => x.Address).ToHashSet();
                if(a.Count != extracted.Length)
                    Wf.Error(Host, $"count(Extracted) = {extracted.Length} != {a.Count} = count(set(Extracted))");

                var b = decoded.Select(f => f.BaseAddress).ToHashSet();
                if(b.Count != decoded.Length)
                    Wf.Error(Host, $"count(Decoded) = {decoded.Length} != {b.Count} = count(set(Decoded))");

                b.IntersectWith(a);
                if(b.Count != decoded.Length)
                    Wf.Error(Host, $"count(Decoded) = {decoded.Length} != {b.Count} = count(intersect(Decoded,Extracted))");

                Wf.Ran(flow);
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }
        }
    }
}