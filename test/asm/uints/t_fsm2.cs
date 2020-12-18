//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public class t_fsm2 : UnitTest<t_fsm2>
    {
        public void run()
        {
            var machineCount = Pow2.T04;
            var spec1 = Fsm.primal<ushort>("Fsm2",750,750,100,120,Pow2.T15);
            var stats = Fsm.run(spec1, machineCount);
            var counts = stats.Select(x => x.ReceiptCount).ToArray().AsSpan().ReadOnly();
            var count = gspan.sum(counts);
            term.inform($"A total of {count} events were processed");
        }
    }
}
