//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_sunpack : t_sinx<t_sunpack>
    {


        public void unpack_16()
        {
            var src = Random.BitVector(n16);
            var dst = DataBlocks.alloc<byte>(n128);
            ginxs.unpack(src, dst);
            for(var i=0; i<dst.CellCount; i++)
                Claim.eq((byte)src[i], dst[i]);

        }

        public void unpack_32()
        {
            var src = Random.BitVector(n32);
            var dst = DataBlocks.alloc<byte>(n256);
            ginxs.unpack(src, dst);
            for(var i=0; i<dst.CellCount; i++)
                Claim.eq((byte)src[i], dst[i]);
            
            

        }

    }
}