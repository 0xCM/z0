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
            var bounds = Interval.closed(1u, 73u);
            var loop = Loops.loop(bounds, 1u);


        }
    }
}
