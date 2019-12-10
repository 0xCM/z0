//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;


    using static zfunc;


    public class t_sbroadcast : t_vinx<t_sbroadcast>
    {

        public void s_broadcast_basecase()
        {
            void case1()
            {
                ulong pattern = 0b11001100;
                var expect = pattern << 0  | pattern << 8  | pattern << 16 | pattern << 24 | 
                               pattern << 32 | pattern << 40 | pattern << 48 | pattern << 56;
                var actual = ginxs.broadcast((byte)pattern, out ulong _);
                Claim.eq(expect,actual);

            }

            void case2()
            {
                ulong pattern = ushort.MaxValue;
                var expect = pattern << 0 | pattern << 16 | pattern << 32 | pattern << 48;  
                var actual = ginxs.broadcast((ushort)pattern, out ulong _);
                Claim.eq(expect,actual);
            }

            void case3()
            {
                ulong pattern = uint.MaxValue;
                var expect = pattern << 0 | pattern << 32;
                var actual = ginxs.broadcast((uint)pattern, out ulong _);
                Claim.eq(expect,actual);
            }

            void case4()
            {
                ulong pattern = ulong.MaxValue;
                var expect = byte.MaxValue;
                var actual = ginxs.broadcast(pattern, out byte _);
                Claim.eq(expect,actual);
            }


            RunLocals();
        }
    }

}