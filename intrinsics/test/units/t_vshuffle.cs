//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static HexConst;
    
    //using static VecParts128x8u;
    public class t_vshuffle : IntrinsicTest<t_vshuffle>
    {        

        static ReadOnlySpan<byte> Inc8u  
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F};


        //Identity
        static ReadOnlySpan<byte> Pattern1  
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F};

        //Reversal
        static ReadOnlySpan<byte> Pattern2  
            => new byte[16]{F,E,D,C,B,A,9,8,7,6,5,4,3,2,1,0};

        public void shuffle_128x8u_1()
        {
            var n = n128;
            var src = ginx.vload(n, in head(Inc8u));
            var spec = ginx.vload(n, in head(Pattern1));
            var dst = dinx.vshuf16x8(src,spec);
            Claim.eq(spec,dst);
        }

        public void shuffle_128x8u_2()
        {
            var n = n128;
            var src = ginx.vload(n, in head(Inc8u));
            var spec = ginx.vload(n, in head(Pattern2));
            var dst = dinx.vshuf16x8(src,spec);
            Claim.eq(spec,dst);

        }

        public void shuffle_128x8u_4()
        {
            var n = n128;
            var src = ginx.vload(n, in head(Inc8u));
            var spec = DataPatterns.rotl(n128, n8);
            var dst = dinx.vshuf16x8(src,spec);
            Claim.eq(spec,dst);
        }

        public void shuffle_128x8u_5()
        {
            var n = n128;
            var src = ginx.vload(n, in head(Inc8u));
            var spec = DataPatterns.rotr(n128, n8);
            var dst = dinx.vshuf16x8(src,spec);
            Claim.eq(spec,dst);
        }

        public void shuffle_128x8u_composite()
        {
            var n = n128;
            var src = ginx.vload(n, in head(Inc8u));
            var spec1 = DataPatterns.rotl(n128, n8);
            var spec2 = DataPatterns.rotr(n128, n8);
            var dst = dinx.vshuf16x8(dinx.vshuf16x8(src,spec1), spec2);
            Claim.eq(src,dst);
        }

        public void shuffle_128x8u()
        {
            var n = n128;
            var mask = ginx.vbroadcast(n,(byte)0b10000000);
            var src = Random.CpuVector<byte>(n);
            var dst = dinx.vshuf16x8(src, mask);
            var zed = ginx.vbroadcast(n,(byte)0);            
            Claim.eq(dst,zed);                        
        }

        public void shuffle_128x32u()
        {
            var n = n128;
            var src = dinx.vparts(1u,2u,3u,4u);
            var spec = Perm4.ABCD;
            var y = dinx.vparts(4u,3u,2u,1u);
            var x = dinx.vperm4x32(src, Perm4.ABCD);
            Claim.eq(x, src);
            Trace($"shuffle({x},{spec}) = {y}");           

            y = dinx.vparts(4u,3u,2u,1u);
            spec = Perm4.DCBA;
            x = dinx.vperm4x32(src,spec);
            Claim.eq(x, y); 
            Trace($"shuffle({x},{spec}) = {y}");           

            y = dinx.vparts(4u,3u,2u,1u);
            spec = Perm4.DCBA;
            x = dinx.vperm4x32(src,spec);
            Claim.eq(x, y); 
            Trace($"shuffle({x},{spec}) = {y}");           

        }


        public void shuffle_128x8u_check()
        {
            var src = ginx.vincrements<byte>(n128);
            var perm = PermSpec.natural(PermSpec.reversed(n16));
            for(int i=0,j=15; i<perm.Length; i++, j--)
                Claim.eq(perm[i],j);

            var shufspec = perm.ToShuffleSpec();
            var dst = dinx.vshuf16x8(src,shufspec);
            var expect = DataPatterns.decrements<byte>(n128);
            Claim.eq(expect, dst);

            var dstPerm = dst.ToPerm();
            var expectPerm = expect.ToPerm();
            Claim.eq(dstPerm, expectPerm);

        }

        public void shuffle_lo_128x16u()
        {
            var id = dinx.vparts(n128, 0,1,2,3,6,7,8,9);
            Claim.eq(dinx.vpermlo4x16(id, Perm4.ADCB), dinx.vparts(n128, 0,3,2,1,6,7,8,9));
        }

        public void shuffle_hi_128x16u()
        {
            var id = dinx.vparts(n128, 0,1,2,3,6,7,8,9);
            Claim.eq(dinx.vpermhi4x16(id, Perm4.ADCB), dinx.vparts(n128,0,1,2,3,6,9,8,7));
        }

        public void shuffle_128x16u()
        {
            var id = dinx.vparts(n128,0,1,2,3,6,7,8,9);
            Claim.eq(dinx.vperm4x16(id, Perm4.ADCB, Perm4.ADCB), dinx.vparts(n128,0,3,2,1,6,9,8,7));
        }

        public void permute128i32()
        {
            var id = dinx.vparts(0,1,2,3);
            Claim.eq(dinx.vperm4x32(id, Perm4.ADCB), dinx.vparts(0,3,2,1));
            Claim.eq(dinx.vperm4x32(id, Perm4.DBCA), dinx.vparts(3,1,2,0));
            Permute4i32();        
        }


        void Permute4i32(bool trace = false)
        {
            var pSrc = Random.EnumValues<Perm4>(x => (byte)x > 5);
            
            for(var i=0; i<CycleCount; i++)
            {
                var v1 = Random.CpuVector<uint>(n128); 
                var v1s = v1.ToSpan();
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
                var v3 = dinx.vparts(v1s[p0],v1s[p1],v1s[p2],v1s[p3]);

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
