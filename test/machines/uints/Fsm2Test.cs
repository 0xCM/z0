//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;

    using Z0.Machines;

    
    public class Fsm2Test : UnitTest<Fsm2Test>
    {

        public void run()
        {
            var machineCount = Pow2.T04;
            var spec1 = PrimalFsm.Specify<ushort>("Fsm2",750,750,100,120,Pow2.T15);
            var stats = PrimalFsm.Run(spec1, machineCount);
            var counts = stats.Select(x => x.ReceiptCount).ToArray().AsSpan().ReadOnly();
            var count = gspan.sum(counts);
            term.inform($"A total of {count} events were processed");
        }
    }
}
