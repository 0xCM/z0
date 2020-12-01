//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;
    using static z;

    public class t_broadcast : t_inx<t_broadcast>
    {
        public void t_broadcast_case1()
        {
            ulong pattern = 0b11001100;
            var expect = pattern << 0  | pattern << 8  | pattern << 16 | pattern << 24 |
                            pattern << 32 | pattern << 40 | pattern << 48 | pattern << 56;
            var actual = broadcast<byte,ulong>((byte)pattern);
            Claim.eq(expect,actual);
        }

        public void t_broadcast_case2()
        {
            ulong pattern = ushort.MaxValue;
            var expect = pattern << 0 | pattern << 16 | pattern << 32 | pattern << 48;
            var actual = broadcast<ushort,ulong>((ushort)pattern);
            Claim.eq(expect,actual);
        }

        public void t_broadcast_case3()
        {
            ulong pattern = uint.MaxValue;
            var expect = pattern << 0 | pattern << 32;
            var actual = broadcast<uint,ulong>((uint)pattern);
            Claim.eq(expect,actual);
        }

        public void t_broadcast_case4()
        {
            ulong pattern = ulong.MaxValue;
            var expect = byte.MaxValue;
            var actual = broadcast<ulong,byte>(pattern);
            Claim.eq(expect,actual);
        }
    }
}