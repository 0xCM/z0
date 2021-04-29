//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public class t_msb_off : t_bits<t_msb_off>
    {
        public void msboff_8u()
            => msboff_check<byte>();

        public void msboff_16u()
            => msboff_check<ushort>();

        public void msboff_32u()
            => msboff_check<uint>();

        public void msboff_64u()
            => msboff_check<ulong>();

        void msboff_check<T>()
            where T : unmanaged
        {
            var width = memory.width<T>();
            for(byte i=0; i<width; i++)
                msboff_check<T>(i);
        }

        void msboff_check<T>(byte maxlen, T t = default)
            where T : unmanaged
        {
            var width = width<T>();

            var bs0 = BitString.scalar(Numeric.maxval(t));
            var bv0 = bs0.ToBitVector<T>();

            Claim.eq(width, bs0.PopCount());
            Claim.eq(width, bs0.Length);

            base.Claim.eq(width, (BitVector32)BitVector.pop(bv0));

            var bs1 = bs0.Truncate(maxlen);
            Claim.eq(maxlen, bs1.PopCount());
            Claim.eq(maxlen, bs1.Length);

            var bv1 = gbits.msboff(bv0.Content, maxlen);
            Claim.eq(maxlen, gbits.pop(bv1));

            var bs2 = bs1.Pad(width);
            Claim.eq(width, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());

            for(var i= 0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var j = Random.Next((uint)2, width - width/2);
                var y = gbits.msboff(x, (byte)j);

                var x0 = gbits.bitseg(x,0, (byte)(j - 1));
                var y0 = gbits.bitseg(y,0, (byte)(j - 1));
                var y1 = gbits.bitseg(y,(byte)j, (byte)(width - 1));
                Claim.eq(x0,y0);
                Claim.nea(gmath.nonz(y1));
            }
        }
    }
}