//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public class t_toggle : t_bitcore<t_toggle>
    {
        public void toggle_8i()
            => toggle_check<sbyte>();

        public void toggle_8u()
            => toggle_check<byte>();

        public void toggle_16i()
            => toggle_check<short>();

        public void toggle_16u()
            => toggle_check<ushort>();

        public void toggle_32i()
            => toggle_check<int>();

        public void toggle_32u()
            => toggle_check<uint>();

        public void toggle_64i()
            => toggle_check<long>();

        public void toggle_64u()
            => toggle_check<ulong>();

        public void toggle_32f()
            => toggle_check<float>();

        public void toggle_64f()
            => toggle_check<double>();

        void toggle_check<T>(T t = default)
            where T : unmanaged
        {
            var src = Random.Span<T>(RepCount);
            var tLen = bitwidth<T>();
            var srcLen = src.Length;
            for(var i = 0; i< srcLen; i++)
            {
                var x = src[i];
                for(byte j =0; j< tLen; j++)
                {
                    var before = gbits.testbit(x, j);
                    x = gbits.toggle(x, j);
                    var after = gbits.testbit(x, j);
                    ClaimNumeric.Neq(before, after);
                    x = gbits.toggle(x, j);
                    Claim.Eq(x, src[i]);
                }
            }
        }

        public void bitsize()
        {
            Claim.eq(8, bitwidth<byte>());
            Claim.eq(8, bitwidth<sbyte>());
            Claim.eq(16, bitwidth<short>());
            Claim.eq(16, bitwidth<ushort>());
            Claim.eq(32, bitwidth<int>());
            Claim.eq(32, bitwidth<uint>());
            Claim.eq(64, bitwidth<long>());
            Claim.eq(64, bitwidth<ulong>());
            Claim.eq(32, bitwidth<float>());
            Claim.eq(64, bitwidth<double>());
        }

        public void testbit_outline()
        {
            Claim.Require(gbits.testbit(0b00000101, (byte)0));
            Claim.nea(gbits.testbit(0b00000101, (byte)1));
            Claim.Require(gbits.testbit(0b00000101, (byte)2));

            Claim.Require(gbits.testbit(0b00000111, (byte)0));
            Claim.Require(gbits.testbit(0b00000111, (byte)1));
            Claim.Require(gbits.testbit(0b00000111, (byte)2));
        }

        public void enable_outline()
        {
            var x1 = (sbyte)0;
            var y1 = Bits.enable(x1, 7);
            Claim.eq(SByte.MinValue, y1);
            ClaimPrimalSeq.eq("10000000", y1.ToBitString());


            var x2 = (byte)0;
            var y2 = Bits.enable(x2, 7);
            Claim.eq(SByte.MinValue, (sbyte)y1);
            ClaimPrimalSeq.eq("10000000", y1.ToBitString());

            var x3 = -1;
            Claim.eq(x3 >> 10, -1);
        }
    }
}