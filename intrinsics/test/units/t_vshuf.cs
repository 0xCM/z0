//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vshuf : t_vinx<t_vshuf>
    {
        public void vshuf_16x8()
        {
            var id = ShuffleIdentityMask();
            for(var i=0; i<DefaltCycleCount; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = dinx.vshuf16x8(x, id);
                Claim.eq(x,y);
            }
        }


        static Vector256<byte> ShuffleIdentityMask()
        {
            Block256<byte> mask = DataBlocks.cellalloc<byte>(n256,1);

            //For the first 128-bit lane
            var half = mask.CellCount/2;
            for(byte i=0; i< half; i++)
                mask[i] = i;

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
                mask[i + half] = i;

            return mask.LoadVector();
        }


    }

}