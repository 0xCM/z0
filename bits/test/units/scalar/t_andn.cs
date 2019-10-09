//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
 
    public class t_andn : ScalarBitTest<t_andn>
    {

        public void scalar_andn_8u()
        {
            scalar_andn_check<byte>();
        }

        public void scalar_andn_16u()
        {
            scalar_andn_check<ushort>();
        }

        public void scalar_andn_32u()
        {
            scalar_andn_check<uint>();
        }

        public void scalar_andn_64u()
        {
            scalar_andn_check<ulong>();
        }


        void scalar_andn_check<T>()
            where T : unmanaged
        {
            var vZero = Vec128<T>.Zero;
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();                    
                var y = Random.Next<T>();                    
                var z1 = gbits.andn(in x, in y);
                var z2 = gmath.and(gmath.flip(x),y);
                Claim.eq(z1,z2);

            }
        }


    }

}