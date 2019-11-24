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
        public void bitrev_8()
            => bitrev_check<byte>();

        public void bitrev_16()
            => bitrev_check<ushort>();
        
        public void bitrev_32()
            => bitrev_check<uint>();

        public void bitrev_64()
            => bitrev_check<ulong>();
        
        void bitrev_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)            
            {
                var src = Random.Next<T>();
                var r1 = gbits.rev(src);
                var r2 = BitString.from(src).Reverse().TakeScalar<T>();
                Claim.eq(r1,r2);
            }

        }
    }
}