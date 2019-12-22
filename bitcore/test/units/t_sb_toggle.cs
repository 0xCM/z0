//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_toggle : t_sb<t_sb_toggle>
    {
        public void sb_toggle_8i()
            => sb_toggle_check<sbyte>();
            
        public void sb_toggle_8u()
            => sb_toggle_check<byte>();

        public void sb_toggle_16i()
            => sb_toggle_check<short>();

        public void sb_toggle_16u()
            => sb_toggle_check<ushort>();

        public void sb_toggle_32i()
            => sb_toggle_check<int>();

        public void sb_toggle_32u()
            => sb_toggle_check<uint>();

        public void sb_toggle_64i()
            => sb_toggle_check<long>();

        public void sb_toggle_64u()
            => sb_toggle_check<ulong>();

        public void sb_toggle_32f()
            => sb_toggle_check<float>();

        public void sb_toggle_64f()
            => sb_toggle_check<double>();        

        public void sb_testbit()
        {
            Claim.yea(gbits.test(0b00000101, (byte)0));
            Claim.nea(gbits.test(0b00000101, (byte)1));
            Claim.yea(gbits.test(0b00000101, (byte)2));
            
            Claim.yea(gbits.test(0b00000111, (byte)0));
            Claim.yea(gbits.test(0b00000111, (byte)1));
            Claim.yea(gbits.test(0b00000111, (byte)2));
        }

        public void sb_bitsize()
        {
            Claim.eq(8, bitsize<byte>());
            Claim.eq(8, bitsize<sbyte>());
            Claim.eq(16, bitsize<short>());
            Claim.eq(16, bitsize<ushort>());
            Claim.eq(32, bitsize<int>());
            Claim.eq(32, bitsize<uint>());
            Claim.eq(64, bitsize<long>());
            Claim.eq(64, bitsize<ulong>());
            Claim.eq(32, bitsize<float>());
            Claim.eq(64, bitsize<double>());
        }

        public void sb_enable_basecase()
        {
            var x1 = (sbyte)0;
            var y1 = BitMask.enable(x1, 7);
            Claim.eq(SByte.MinValue, y1);
            Claim.eq("10000000", y1.ToBitString());


            var x2 = (byte)0;
            var y2 = BitMask.enable(x2, 7);
            Claim.eq(SByte.MinValue, (sbyte)y1);
            Claim.eq("10000000", y1.ToBitString());

            var x3 = -1;
            Claim.eq(x3 >> 10, -1);
            
        }
    }

}