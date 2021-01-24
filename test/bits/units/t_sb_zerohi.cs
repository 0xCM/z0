//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    public class t_sb_zerohi : t_bitcore<t_sb_zerohi>
    {
        public void sb_zerohi_8u()
            => sb_zerohi_check<byte>();

        public void sb_zerohi_16u()
            => sb_zerohi_check<ushort>();

        public void sb_zerohi_32u()
            => sb_zerohi_check<uint>();

        public void sb_zerohi_64u()
            => sb_zerohi_check<ulong>();

        void sb_zerohi_check<T>(T t = default)
            where T : unmanaged
        {
            var width = bitwidth<T>();
            for(byte i=0; i<width; i++)
                sb_zerohi_check<T>(i);
        }

        void sb_zerohi_check<T>(byte maxlen, T t = default)
            where T : unmanaged
        {
            var width = bitwidth<T>();

            var bs0 = BitString.scalar(maxval(t));
            var bv0 = bs0.ToBitVector<T>();

            Claim.eq(width, bs0.PopCount());
            Claim.eq(width, bs0.Length);

            base.Claim.eq(width, (BitVector32)BitVector.pop(bv0));

            var bs1 = bs0.Truncate(maxlen);
            Claim.eq(maxlen, bs1.PopCount());
            Claim.eq(maxlen, bs1.Length);

            var bv1 = gbits.bzhi(bv0.Scalar, maxlen);
            Claim.eq(maxlen, gbits.pop(bv1));

            var bs2 = bs1.Pad(width);
            Claim.eq(width, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());

            for(var i= 0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var j = Random.Next(2, width - width/2);
                var y = gbits.bzhi(x, (byte)j);

                var x0 = gbits.segment(x,0, (byte)(j - 1));
                var y0 = gbits.segment(y,0, (byte)(j - 1));
                var y1 = gbits.segment(y,(byte)j, (byte)(width - 1));
                Claim.eq(x0,y0);
                Claim.nea(gmath.nonz(y1));
            }
        }
    }
}