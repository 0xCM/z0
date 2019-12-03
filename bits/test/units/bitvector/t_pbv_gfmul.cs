//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_pbv_gfmul : t_bv<t_pbv_gfmul>
    {
        public void pbv_gfmul_8()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var v1 = Random.BitVector(n8);
                var v2 = Random.BitVector(n8);
                var p1 = Gf256.clmul(v1,v2); 
                var p2 = Gf256.clmul((byte)v1, (byte)v2);
                var p4 = Gf256.mul_ref(v1,v2);

                Claim.eq(p1,p2);
                Claim.eq(p1,p4);
            }
        }

        public void pbv_gfmul_8_bench()
        {
            var lhsSrc = Random.Stream<byte>().Take(SampleSize).Select(x => BitVector.from(n8,x)).ToArray();
            var rhsSrc = Random.Stream<byte>().Take(SampleSize).Select(x => BitVector.from(n8,x)).ToArray();
            var result = BitVector.alloc(n8);
            int Bench()
            {                
                for(var i=0; i< CycleCount; i++)
                for(var j=0; j< SampleSize; j++)
                    result &= lhsSrc[j] * rhsSrc[j];
                return SampleSize * CycleCount;
            }   

            Measure(Bench);
        }

        public void gfpoly_format()
        {
            var p1 = GfPoly.Gfp_8_4_3_2_0;
            var p2 = GfPoly16.FromExponents(8,4,3,2,0);
            var p3 = GfPoly16.FromScalar(0b100011101);

            Claim.eq(p3.Degree,(byte)8);                        
            Claim.eq(p1.Scalar, p2.Scalar);
            Claim.eq(p1.Format(),p2.Format());                
        }

        public void gfmul_8()
        {
            var expect =  new byte[,]
            {
                {0b001, 0b010, 0b011, 0b100, 0b101, 0b110, 0b111},
                {0b010, 0b100, 0b110, 0b011, 0b001, 0b111, 0b101},
                {0b011, 0b110, 0b101, 0b111, 0b100, 0b001, 0b010},
                {0b100, 0b011, 0b111, 0b110, 0b010, 0b101, 0b001},
                {0b101, 0b001, 0b100, 0b010, 0b111, 0b011, 0b110},
                {0b110, 0b111, 0b001, 0b101, 0b011, 0b010, 0b100},
                {0b111, 0b101, 0b010, 0b001, 0b110, 0b100, 0b011}
            };

            var actual = Gf8.products();

            var description = text();
            for(var i=0; i<7; i++)
            {
                for(var j=0; j<7; j++)
                {                    
                    description.Append(expect[i,j].ToBitString().Truncate(3).Format());
                    if(j != 6)
                        description.Append(AsciSym.Pipe);
                }
                description.AppendLine();
            }

            for(var i=0; i<7; i++)
            for(var j=0; j<7; j++)
                Claim.eq(expect[i,j], actual[i,j]);
        }

        public void gfpoly()
        {            
            gfpoly_check(GfPoly.Lookup<N3,byte>(), BitString.parse("1011"));            
            gfpoly_check(GfPoly.Lookup<N8,ushort>(), BitString.parse("100011101"));
            Claim.eq((ushort)0b100011101, GfPoly.Lookup<N8,ushort>().Scalar);
            
            gfpoly_check(GfPoly.Lookup<N16,uint>(), BitString.parse("10000001111011101"));            
        }

        void gfpoly_check<N,T>(GfPoly<N,T> p, BitString match)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var bs = BitString.scalar(p.Scalar).Truncate(p.Degree + 1);
            Claim.eq(bs, match);  
        }
    }
}