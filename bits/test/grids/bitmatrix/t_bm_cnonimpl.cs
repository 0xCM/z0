//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bm_cnonimpl : t_bm<t_bm_cnonimpl>
    {                
        public void bm_not_32x32x32()
        {
            for(var i=0; i<RepCount; i++)
            {
                var A = Random.BitMatrix(n32);
                var B = BitMatrix.not(A);
                var C = BitMatrix.from(n32, gspan.not(A.Bytes.Replicate(), A.Bytes.Replicate()));
                Claim.yea(B == C);
                
            }
        }

        public void bm_cnonimpl_8x8x8()
        {
            var lhs = Random.BitMatrix8();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void bm_cnonimpl_16x16x16()
        {
            var lhs = Random.BitMatrix16();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void bm_cnonimpl_32x32x32()
        {
            var lhs = Random.BitMatrix32();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void bm_cnonimpl_64x64x64()
        {
            var lhs = Random.BitMatrix64();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }
    }
}