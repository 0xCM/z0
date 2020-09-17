//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public class t_bitwidth : t_bitcore<t_bitwidth>
    {
        public void bitwidth_outline()
        {
            var x = (byte)0b0;
            var w = gbits.effwidth(x);
            Claim.eq(w,0);

            x = (byte)0b00010000;
            w = gbits.effwidth(x);
            Claim.eq(w,5);

            x = (byte)0b00000001;
            w = gbits.effwidth(x);
            Claim.eq(w,1);

            x = (byte)0b10000000;
            w = gbits.effwidth(x);
            Claim.eq(w,8);

        }

        public void bitwidth_8u()
            => sb_width_check<byte>();

        public void bitwidth_16u()
            => sb_width_check<ushort>();

        public void bitwidth_32u()
            => sb_width_check<uint>();

        public void bitwidth_64u()
            => sb_width_check<ulong>();

        protected void sb_width_check<T>(T t = default)
            where T : unmanaged
        {
            for(var sample = 0; sample < RepCount; sample++)
            {
                var x = Random.Next<T>();
                var actual = gbits.effwidth(x);
                var expect = bitwidth<T>() - gbits.nlz(x);
                Claim.eq(expect, actual);

            }
        }
    }
}