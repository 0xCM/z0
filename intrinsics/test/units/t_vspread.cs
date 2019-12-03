//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static HexConst;

    public class t_vspread : IntrinsicTest<t_vspread>
    {     

        public void vmaskstore_128x8u_basecase()
        {
            const byte pick = Pow2.T07;
            const byte skip = 0;
            var n = n128;
            var src =  dinx.vparts(n,    0,   AA,    0,    0,   0,   AA,   AA,   AA,     0,    0,    0,   AA,   AA,   AA,    0,    0);
            var mask = dinx.vparts(n, skip, pick, skip, skip, skip, pick, pick, pick, skip, skip, skip, pick, pick, pick, skip, skip);
            var dst = DataBlocks.single<byte>(n);
            dst.Fill(FF);
            ginx.vmstore(src, mask, ref dst.Head);
            for(var i=0; i<16; i++)
            {
                var expect = gbits.test(mask.Item(i), 7) ? AA : FF;
                var actual = dst[i];
                Claim.eq(expect,actual);
            }
        }

        public void vspread_128x8u()
        {
            var src = ginx.vincrements<byte>(n128);
            dinx.vinflate(src, out Vector128<ushort> lo, out Vector128<ushort> hi);
            var loExpect = ginx.vincrements<ushort>(n128);
            var hiExpect = ginx.vincrements<ushort>(n128,8);
            Claim.eq(loExpect, lo);
            Claim.eq(hiExpect, hi);

            var dst = dinx.vcompact(lo,hi);
            Claim.eq(src,dst);
        }



        public void vspread_128x8u_128x16u()
        {
            var src = ginx.vincrements<byte>(n128);            
            dinx.vinflate(src, out Vector128<ushort> lo, out Vector128<ushort> hi);
            for(var i=0; i<8; i++)
                Claim.eq(src.Item(i), lo.Item(i));
            

        }


    }

}