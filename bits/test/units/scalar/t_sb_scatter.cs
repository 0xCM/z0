//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public class t_sb_scatter : t_sb<t_sb_scatter>
    {        
        public void sb_scatter_basecase()
        {
            var src1 = 0b00000000_00000000_00000000_10101010u;
            var m1 =   0b00000011_00000011_00000011_00000011u;             
            var d1e =  0b00000010_00000010_00000010_00000010u;
            var d1a = gbits.scatter(src1, m1);
            Claim.eq(d1e,d1a);
        }

        public void sb_scatter_8()
            => sb_scatter_check<byte>();

        public void sb_scatter_16()
            => sb_scatter_check<ushort>();

        public void sb_scatter_32()
            => sb_scatter_check<uint>();

        public void s_scatter_64()
            => sb_scatter_check<ulong>();
    }
}