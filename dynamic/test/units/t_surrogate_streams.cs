//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Nats;
    using static VectorSurrogates;

    public class t_surrogate_streams : UnitTest<t_surrogate_streams>
    {    
        public void surrogat_stream_128()
        {
            var n = n128;
            foreach(var k in Numeric.IntegralKinds)
            {                
                var emitter = Random.CpuSurrogateEmitter(n, k);
                var emission = emitter().Take(10);
                iter(emission, describe);
            }
        }
        void describe(IVec128 src)
        {
            Notify($"Contained in {src.ContainerType.DisplayName()}, Value: {src}");
        }
    }
}