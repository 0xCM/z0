//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    
    public class tv_shuffle : IntrinsicTest<tv_shuffle>
    {        
        public void shuffle_128x8u()
        {
            var mask = Vec128.Fill((byte)0b10000000);
            var src = Random.CpuVec128<byte>();
            var dst = dinx.shuffle(in src, in mask);
            var zed = Vec128.Fill((byte)0);            
            Claim.eq(dst,zed);                        
        }

        public void shuffle_128x32u()
        {
            var src = Vec128.FromParts(1u,2u,3u,4u);
            var spec = Perm4.ABCD;
            var y = Vec128.FromParts(4u,3u,2u,1u);
            var x = dinx.shuffle(src, Perm4.ABCD);
            Claim.eq(x, src);
            Trace($"shuffle({x},{spec}) = {y}");           

            y = Vec128.FromParts(4u,3u,2u,1u);
            spec = Perm4.DCBA;
            x = dinx.shuffle(src,spec);
            Claim.eq(x, y); 
            Trace($"shuffle({x},{spec}) = {y}");           

            y = Vec128.FromParts(4u,3u,2u,1u);
            spec = Perm4.DCBA;
            x = dinx.shuffle(src,spec);
            Claim.eq(x, y); 
            Trace($"shuffle({x},{spec}) = {y}");           

        }


        public void shuffle_lo_128x16u()
        {
            var id = Vec128.FromParts(0,1,2,3,6,7,8,9);
            Claim.eq(dinx.shufflelo(id, Perm4.ADCB), Vec128.FromParts(0,3,2,1,6,7,8,9));
        }

        public void shuffle_hi_128x16u()
        {
            var id = Vec128.FromParts(0,1,2,3,6,7,8,9);
            Claim.eq(dinx.shufflehi(id, Perm4.ADCB), Vec128.FromParts(0,1,2,3,6,9,8,7));
        }

        public void shuffle_128x16u()
        {
            var id = Vec128.FromParts(0,1,2,3,6,7,8,9);
            Claim.eq(dinx.shuffle(id,Perm4.ADCB, Perm4.ADCB), Vec128.FromParts(0,3,2,1,6,9,8,7));
        }

        public void permute128i32()
        {
            var id = Vec128.FromParts(0,1,2,3);
            Claim.eq(dinx.vperm4x32(id, Perm4.ADCB), Vec128.FromParts(0,3,2,1));
            Claim.eq(dinx.vperm4x32(id, Perm4.DBCA), Vec128.FromParts(3,1,2,0));
            Permute4i32();        
        }

        public void shuffle128i32()
        {
            var v1 = Vec128.FromParts(0, 1, 2, 3);
            
            //Produces the identity permutation
            var m1 = (byte)0b11_10_01_00;
            
            //Reversal
            var m2 = (byte)0b00_01_10_11;

            //RotL(1)
            var m3 = (byte)0b10_01_00_11;

            var s1 = dinx.shuffle(v1,m1);
            var s2 = dinx.shuffle(v1,m2);
            var s3 = dinx.shuffle(v1,m3);            
        }

        void Permute4i32(int cycles = DefaltCycleCount, bool trace = false)
        {
            var pSrc = Random.EnumValues<Perm4>(x => (byte)x > 5);
            
            for(var i=0; i<cycles; i++)
            {
                var v1 = Random.CpuVec128<int>(); 
                var p = pSrc.First();
                
                // Disassemble the spec
                var p0 = Bits.gather((byte)p, (byte)0b11);                
                var p1 = Bits.gather((byte)p, (byte)0b1100);
                var p2 = Bits.gather((byte)p, (byte)0b110000);
                var p3 = Bits.gather((byte)p, (byte)0b11000000);
                
                // Reassemble the spec
                Perm4 q = (Perm4)(p0 | p1 << 2 | p2 << 4 | p3 << 6);
                
                // Same?
                Claim.eq(p,q);

                // Permute vector via api
                var v2 = dinx.vperm4x32(v1,p);

                // Permute vector manually
                var v3 = Vec128.FromParts(v1[p0],v1[p1],v1[p2],v1[p3]);

                // Same?
                Claim.eq(v3,v2);

                if(trace)
                {
                    Trace("v1",v1.FormatHex());                
                    Trace("p", p.Format());
                    Trace("perm(v1,p)", v2.FormatHex());
                }
                                
            }
        }

    }

}
