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

    public class t_reverse : ScalarBitTest<t_reverse>
    {
        public void rev_check_8()
            => rev_check<byte>();

        public void rev_check_16()
            => rev_check<ushort>();
        
        public void rev_check_32()
            => rev_check<uint>();

        public void rev_check_64()
            => rev_check<ulong>();
        
        void rev_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)            
            {
                var src = Random.Next<T>();
                var r1 = gbits.rev(src);
                var r2 = BitString.FromScalar(src).Reverse().TakeScalar<T>();
                Claim.eq(r1,r2);
            }

        }
    }
}