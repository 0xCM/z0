//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class t_bzhi : t_sb<t_bzhi>
    {    
        public void bzhi_8u_check()
            => bzhi_check<byte>();

        public void bzhi_16u_check()
            => bzhi_check<ushort>();

        public void bzhi_32u_check()
            => bzhi_check<uint>();

        public void bzhi_64u_check()
            => bzhi_check<ulong>();

        void bzhi_check<T>()
            where T : unmanaged
        {
            var width = bitsize<T>();
            for(var i=0; i< width; i++)
                bzhi_check<T>(i);            
        }

        void bzhi_check<T>(int maxlen)
            where T : unmanaged
        {
            var width = bitsize<T>();

            var bs0 = BitString.from(gmath.maxval<T>());
            var bv0 = bs0.ToBitVector<T>();

            Claim.eq(width, bs0.PopCount());
            Claim.eq(width, bs0.Length);

            Claim.eq(width, BitVector.pop(bv0));
            
            var bs1 = bs0.Truncate(maxlen);
            Claim.eq(maxlen, bs1.PopCount());
            Claim.eq(maxlen, bs1.Length);

            var bv1 = gbits.zerohi(bv0.Scalar, maxlen);
            Claim.eq(maxlen, gbits.pop(bv1));

            var bs2 = bs1.Pad(width);
            Claim.eq(width, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());

            for(var i= 0; i< SampleSize; i++)
            {
                var x = Random.Next<T>();
                var j = Random.Next(2u, width - width/2);
                var y = gbits.zerohi(x, (int)j);

                var x0 = gbits.range(x,0,j - 1);
                var y0 = gbits.range(y,0,j - 1);
                var y1 = gbits.range(y,j, width - 1);
                Claim.eq(x0,y0);
                Claim.nea(gmath.nonzero(y1));                        
            }
        }
    }
}
