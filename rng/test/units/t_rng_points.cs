//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static Nats;
    using static Root;
    
    public class t_rng_points : UnitTest<t_rng_points>
    {    

        public void rng_point_stream()
        {
            var source = Random.PointStream((z8,z16,z32));
            var dst = source.Take(100).ToArray();
            var indexed = dst.Index();
        }

        public void rng_point_span_emitter()
        {
            
            var emitter = Random.PointSpanEmitter(100, (z8,z16,z32));
            var emisson = emitter.Invoke();
            Claim.eq(100, emisson.Length);

        }

        public void rng_nat_point_span_emitter()
        {
            var emitter = Random.HomPointSpanEmitter(100, n3, z32);
            var emission = emitter.Invoke();
            Claim.eq(100, emission.Length);
            for(var i=0; i< emission.Length; i++)
            {
                var emitted = emission[i];
            }
            

        }

        void print<N,T>(HomPoints<N,T> index)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<index.Count; i++)
            {
                var point = index[i];
                NotifyConsole($"{point}");
            }
        }
        public void rng_fixed_point_index()
        {
            var u8Index = Random.FixedHomPointIndex<Fixed8>(100,n2);
            print(u8Index);

            var u16Index = Random.FixedHomPointIndex<Fixed16>(100,n2);
            print(u16Index);


        }

    }

}
