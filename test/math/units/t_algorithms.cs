//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public class t_algorithms : t_mathsvc<t_algorithms>
    {
        public void t_loops_1()
        {
            var bounds = Interval.closedL(1u, 73u);
            var loop = gAlg.loop(bounds, 1u);
            Trace(loop);
            // var accumulate = new Accrue<uint>();
            // gAlg.run(loop, ref accumulate);
            // Trace($"{loop} -> {accumulate}");

       }
    }
}
