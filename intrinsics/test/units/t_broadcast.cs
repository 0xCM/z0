//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_broadcast : t_vinx<t_broadcast>
    {
        public void broadcast_outline()
        {
            void case1()
            {
                ulong pattern = 0b11001100;
                var expect = pattern << 0  | pattern << 8  | pattern << 16 | pattern << 24 | 
                               pattern << 32 | pattern << 40 | pattern << 48 | pattern << 56;
                var actual = ginxs.broadcast<byte,ulong>((byte)pattern);
                Claim.eq(expect,actual);

            }

            void case2()
            {
                ulong pattern = ushort.MaxValue;
                var expect = pattern << 0 | pattern << 16 | pattern << 32 | pattern << 48;  
                var actual = ginxs.broadcast<ushort,ulong>((ushort)pattern);
                Claim.eq(expect,actual);
            }

            void case3()
            {
                ulong pattern = uint.MaxValue;
                var expect = pattern << 0 | pattern << 32;
                var actual = ginxs.broadcast<uint,ulong>((uint)pattern);
                Claim.eq(expect,actual);
            }

            void case4()
            {
                ulong pattern = ulong.MaxValue;
                var expect = byte.MaxValue;
                var actual = ginxs.broadcast<ulong,byte>(pattern);
                Claim.eq(expect,actual);
            }

            case1();
            case2();
            case3();
            case4();
        }
    }
}