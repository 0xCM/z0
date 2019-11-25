//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_nbv_basic : BitVectorTest<t_nbv_basic>
    {

        public void nbv_bs_4x32u()
            => nbv_bs_check<N4,uint>();

        public void nbv_bs_4x8u()
            => nbv_bs_check<N4,byte>();

        public void nbv_bs_25x32u()
            => nbv_bs_check<N25,ulong>();

        public void nbv_bs_59x64u()
            => nbv_bs_check<N59,ulong>();

        public void nbv_rev_4x32u()
            => nbv_rev_check<N4,uint>();

        public void nbv_rev_4x8u()
            => nbv_rev_check<N4,byte>();

        public void nbv_rev_13x32u()
            => nbv_rev_check<N13,uint>();

        public void nbv_rev_25x32u()
            => nbv_rev_check<N25,ulong>();

        public void nbv_rev_59x64u()
            => nbv_rev_check<N59,ulong>();

        void nbv_rev_check<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.BitVector<N,T>();
                var y = BitVector.rev(x);
                var z = x.ToBitString().Reverse().ToBitVector<N,T>();
                Claim.eq(y,z);
            }
        }

        public void nbv_bs_check<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.BitVector<N,T>();
                var y = x.ToBitString();
                Claim.eq(natval<N>(), x.Width);
                Claim.eq(x.Width, y.Length);
                
                var z = y.ToBitVector<N,T>();                        
                Claim.eq(x,z);
            }           
        }
    }
}