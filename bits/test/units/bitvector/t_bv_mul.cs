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

    public class t_bv_mul : BitVectorTest<t_bv_mul>
    {
        public void bvmul_8u_check()
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

        public void bvmul_8u_bench()
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

        public void gfmul8()
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

            var text = sbuild();
            for(var i=0; i<7; i++)
            {
                for(var j=0; j<7; j++)
                {                    
                    text.Append(expect[i,j].ToBitString().Truncate(3).Format());
                    if(j != 6)
                        text.Append(AsciSym.Pipe);
                }
                text.AppendLine();
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

        void gfmul256ref_bench()
        {
            var lhsSrc = Random.Array<byte>(SampleSize);
            var rhsSrc = Random.Array<byte>(SampleSize);
                        
            int Bench()
            {                
                var ops = 0;
                for(var i=0; i< CycleCount; i++)
                {
                    for(var j=0; j< SampleSize; j++)
                    {
                        Gf256.mul_ref(lhsSrc[j],rhsSrc[j]);
                        ops++;
                    }
                }
                return ops;
            }   

            Measure(Bench);
        }

        void gfpoly_check<N,T>(GfPoly<N,T> p, BitString match)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {

            var bs = BitString.from(p.Scalar).Truncate(p.Degree + 1);
            Claim.eq(bs, match);  

        }
    }
}