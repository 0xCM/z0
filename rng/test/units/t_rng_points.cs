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


        public void rng_nat_point_span_emitter()
        {
            var emitter = Random.PointSpan(100, n3, z32);
            var emission = emitter.Invoke();
            Claim.eq(100, emission.Length);
            for(var i=0; i< emission.Length; i++)
            {
                var emitted = emission[i];
            }
            

        }

        void print<N,T>(Points<N,T> index)
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
            var u8Index = Random.FixedPoints<Fixed8>(100,n2);
            print(u8Index);

            var u16Index = Random.FixedPoints<Fixed16>(100,n2);
            print(u16Index);


        }

    }

}
