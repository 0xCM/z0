//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bv_perm : t_bv<t_bv_perm>
    {        
        public void pbv_perm_8()
        {        
            var perm = Perm.natural<N8>((2,3), (6,7));
            var bs1 = ((byte)0b10001101).ToBitString();
            var bs2 = BitString.parse("01001101");
            var bs3 = bs1.Permute(perm);
            Claim.eq(bs2, bs3);            

        }

        public void pbv_perm_16()
        {        
            var p2 = Perm.natural<N16>((1,10), (2,11), (3, 8));
            var bsx2 = ((ushort)0b1000110111000100).ToBitString();
            var bsy2 =  BitString.load(bsx2.BitSeq.Permute(p2));
            var bsz2 = bsx2.Permute(p2);            
            Claim.eq(bsy2, bsz2);

        }

        public void pbv_perm_32()
        {
            var p1 = Perm.natural(n32, (31,0), (30,1), (29,2));
            Claim.eq(p1[0],31);
            Claim.eq(p1[1],30);
            Claim.eq(p1[2],29);
            Claim.eq(p1[3], 3);

            var bm = p1.ToBitMatrix();
            Claim.eq(bm[0,31], bit.On);
            Claim.eq(bm[1,30], bit.On);
            Claim.eq(bm[2,29], bit.On);


            var v1 = BitVector32.Zero;
            var v2 = v1.Permute(p1);

            Claim.eq(v1[31],v2[0]);
            Claim.eq(v1[30],v2[1]);
            Claim.eq(v1[29],v2[2]);
        }

        public void pbv_perm_64()
        {
            var p = Perm.natural(n64, (0,1),(1,2),(2,3),(3,4),(4,5),(5,6));
            var bv = BitVector.perm(BitVector64.One,p);
            Claim.eq(bv[6], bit.On);

            for(var j=0; j<SampleSize; j++)
            {
                var p1 = Random.Perm(n64);
                var v1 = Random.BitVector(n64);
                var v2 = BitVector.perm(v1,p1);
                for(var i=0; i<v1.Width; i++)
                    Claim.eq(v1[p1[i]], v2[i]);
            }
        }
    }
}