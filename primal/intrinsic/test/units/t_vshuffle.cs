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
    
    using static VecParts128x8u;
    using static Vec128PatternData;
    public class t_vshuffle : IntrinsicTest<t_vshuffle>
    {        

        static ReadOnlySpan<byte> Inc8u  
            => new byte[16]{A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P};

        static ReadOnlySpan<byte> Dec8u 
            => new byte[16]{P,O,N,M,L,K,J,I,H,G,F,E,D,C,B,A};

        //Identity
        static ReadOnlySpan<byte> Pattern1  
            => new byte[16]{A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P};

        //Reversal
        static ReadOnlySpan<byte> Pattern2  
            => new byte[16]{P,O,N,M,L,K,J,I,H,G,F,E,D,C,B,A};

        //hi/lo swap
        static ReadOnlySpan<byte> Pattern3  => new byte[16]{I,J, K,L, M,N, O,P, A,B, C,D, E,F, G,H};


        public void shuffle_128x8u_1()
        {
            var n = n128;
            var src = ginx.vloadu(n, in head(Inc8u));
            var spec = ginx.vloadu(n, in head(Pattern1));
            var dst = dinx.vshuffle(src,spec);
            Claim.eq(spec,dst);
        }

        public void shuffle_128x8u_2()
        {
            var n = n128;
            var src = ginx.vloadu(n, in head(Inc8u));
            var spec = ginx.vloadu(n, in head(Pattern2));
            var dst = dinx.vshuffle(src,spec);
            Claim.eq(spec,dst);

        }

        public void shuffle_128x8u_3()
        {
            var n = n128;
            var src = ginx.vloadu(n, in head(Inc8u));
            var spec = ginx.vloadu(n, in head(Pattern3));
            var dst = dinx.vshuffle(src,spec);
            Claim.eq(spec,dst);
        }

        public void shuffle_128x8u_4()
        {
            var n = n128;
            var src = ginx.vloadu(n, in head(Inc8u));
            var spec = ginx.vloadu(n, in head(RotL_8x8u));
            var dst = dinx.vshuffle(src,spec);
            Claim.eq(spec,dst);
        }

        public void shuffle_128x8u_5()
        {
            var n = n128;
            var src = ginx.vloadu(n, in head(Inc8u));
            var spec = ginx.vloadu(n, in head(RotR_8x8u));
            var dst = dinx.vshuffle(src,spec);
            Claim.eq(spec,dst);
        }

        public void shuffle_128x8u_composite()
        {
            var n = n128;
            var src = ginx.vloadu(n, in head(Inc8u));
            var spec1 = ginx.vloadu(n, in head(RotL_8x8u));
            var spec2 = ginx.vloadu(n, in head(RotR_8x8u));
            var dst = dinx.vshuffle(dinx.vshuffle(src,spec1), spec2);
            Claim.eq(src,dst);
        }

        public void shuffle_128x8u()
        {
            var n = n128;
            var mask = ginx.vbroadcast(n,(byte)0b10000000);
            var src = Random.CpuVector<byte>(n);
            var dst = dinx.vshuffle(src, mask);
            var zed = ginx.vbroadcast(n,(byte)0);            
            Claim.eq(dst,zed);                        
        }

        public void shuffle_128x32u()
        {
            var n = n128;
            var src = v128(1u,2u,3u,4u);
            var spec = Perm4.ABCD;
            var y = v128(4u,3u,2u,1u);
            var x = dinx.vshuffle(src, Perm4.ABCD);
            Claim.eq(x, src);
            Trace($"shuffle({x},{spec}) = {y}");           

            y = v128(4u,3u,2u,1u);
            spec = Perm4.DCBA;
            x = dinx.vshuffle(src,spec);
            Claim.eq(x, y); 
            Trace($"shuffle({x},{spec}) = {y}");           

            y = v128(4u,3u,2u,1u);
            spec = Perm4.DCBA;
            x = dinx.vshuffle(src,spec);
            Claim.eq(x, y); 
            Trace($"shuffle({x},{spec}) = {y}");           

        }


        public void shuffle_lo_128x16u()
        {
            var id = v128(0,1,2,3,6,7,8,9);
            Claim.eq(dinx.vshufflelo(id, Perm4.ADCB), v128(0,3,2,1,6,7,8,9));
        }

        public void shuffle_hi_128x16u()
        {
            var id = v128(0,1,2,3,6,7,8,9);
            Claim.eq(dinx.vshufflehi(id, Perm4.ADCB), v128(0,1,2,3,6,9,8,7));
        }

        public void shuffle_128x16u()
        {
            var id = v128(0,1,2,3,6,7,8,9);
            Claim.eq(dinx.vshuffle(id,Perm4.ADCB, Perm4.ADCB), v128(0,3,2,1,6,9,8,7));
        }

        public void permute128i32()
        {
            var id = v128(0,1,2,3);
            Claim.eq(dinx.vshuffle(id, Perm4.ADCB), v128(0,3,2,1));
            Claim.eq(dinx.vshuffle(id, Perm4.DBCA), v128(3,1,2,0));
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
                var v2 = dinx.vshuffle(v1,p);

                // Permute vector manually
                var v3 = v128(v1s[p0],v1s[p1],v1s[p2],v1s[p3]);

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
