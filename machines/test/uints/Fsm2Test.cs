//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Threading;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Z0.Machines;

    using static zfunc;
    
    public class Fsm2Test : UnitTest<Fsm2Test>
    {


        public void run()
        {
            var machineCount = Pow2.T04;
            var spec1 = PrimalFsm.Specify<ushort>("Fsm2",750,750,100,120,Pow2.T15);
            var stats = PrimalFsm.Run(spec1, machineCount);
            var counts = stats.Select(x => x.ReceiptCount).ToArray().AsSpan().ReadOnly();
            var count = mathspan.sum(counts);
            inform($"A total of {count} events were processed");


        }
    }
}
