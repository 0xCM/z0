//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

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
            var tLen = bitsize<T>();
            var srcLen = src.Length;
            for(var i = 0; i< srcLen; i++)
            {
                var x = src[i];
                for(byte j =0; j< tLen; j++)
                {
                    var before = gbits.test(x, j);
                    x = BitMask.toggle(x, j);
                    var after = gbits.test(x, j);
                    Claim.neq(before, after);
                    x = BitMask.toggle(x, j);
                    Claim.eq(x, src[i]);
                }
            }
        }

        public void bitsize()
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

        public void testbit_outline()
        {
            Claim.yea(gbits.test(0b00000101, (byte)0));
            Claim.nea(gbits.test(0b00000101, (byte)1));
            Claim.yea(gbits.test(0b00000101, (byte)2));
            
            Claim.yea(gbits.test(0b00000111, (byte)0));
            Claim.yea(gbits.test(0b00000111, (byte)1));
            Claim.yea(gbits.test(0b00000111, (byte)2));
        }


        public void enable_outline()
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