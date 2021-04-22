//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class t_bv_bitparts : t_bits<t_bv_bitparts>
    {
        public void bv_bitparts_32x16()
        {
            Span<BitVector16> dst = stackalloc BitVector16[2];
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n32);
                BitVector.pack16x2(x, dst);
                Claim.eq(dst[0], x.Lo);
                Claim.eq(dst[1], x.Hi);
            }
        }

        public void bv_bitparts_32x4()
        {
            Span<BitVector4> dst = stackalloc BitVector4[8];
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n32);
                BitVector.pack4x8(x,dst);
                for(byte j=0,k=0; j<28; j+=4, k++)
                {
                    var y = (BitVector4)x[j,(byte)(j+4)];
                    Claim.eq(y, dst[k]);
                }
            }
        }
    }
}
