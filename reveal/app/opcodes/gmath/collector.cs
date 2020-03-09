//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmathops
    {

        public static ulong avgz_64u_g(ReadOnlySpan<ulong> src)
            => gspan.avgz<ulong>(src);

        public static Collector collector_create()
            => Collector.Create(0);

        public static void collector_collect_seq(Collector collector)
        {
            for(var i=1; i<255; i++)
                collector.Collect(i);
        }

        public static void collector_collect_op(Collector collector)
        {
            collector += 3;
            collector += 4;
            collector += 5;
        }


    }

}