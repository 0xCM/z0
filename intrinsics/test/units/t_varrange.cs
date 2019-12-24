//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static HexConst;

    public class t_varrange : t_vinx<t_varrange>
    {     

        public void vduplicate32x0_256x32u_outline()
        {
            var n = n256;
            var width = n32;

            var x0 = CpuVector.parts(n, 0,1,2,3,4,5,6,(uint)7);
            var y0 = dinx.vduplicate(n0,width,x0);
            var z0 = dinx.vduplicate(n1,width,x0);
            Claim.eq(y0, CpuVector.parts(n, 0,0,2,2,4,4,6,(uint)6));
            Claim.eq(z0, CpuVector.parts(n, 1,1,3,3,5,5,7,(uint)7));            

            var x1 = CpuVector.parts(n,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y1 = dinx.vduplicate(n0,width,x1);
            var z1 = dinx.vduplicate(n1,width,x1);
            Claim.eq(y1, CpuVector.parts(n,0,1, 0,1, 4,5, 4,5, 8,9, 8,9, C,D, C,D));
            Claim.eq(z1, CpuVector.parts(n,2,3, 2,3, 6,7, 6,7, A,B, A,B, E,F, E,F));
            
            var x2 = CpuVector.parts(n,
                ulong.MaxValue & 0x55555555AAAAAAAA, 
                ulong.MaxValue & 0xCCCCCCCC88888888, 
                ulong.MaxValue & 0x3333333377777777,
                ulong.MaxValue & 0x2222222244444444);
            var y2 = dinx.vduplicate(n0, n64, x2);
            var z2 = dinx.vduplicate(n1,n64, x2);
        }
        
        public void vreverse_128x8u_outline()
        {
            var n = n128;
            var v1 = CpuVector.vincrements<byte>(n);
            var v2 = CpuVector.vdecrements<byte>(n);
            var v3 = dinx.vreverse(v1);
            Claim.eq(v2,v3);
        }

        public void vreverse_256x8u_outline()
        {
            var n = n256;
            var v1 = CpuVector.vincrements<byte>(n);
            var v2 = CpuVector.vdecrements<byte>(n);            
            var v3 = dinx.vreverse(v1);
            Claim.eq(v2,v3);
        }

        public void alt_256x8u_outline()
        {
            var n = n256;
            var x = CpuVector.alt(n, 0xAA, 0x55);
            var xs = x.ToSpan();
            for(var i=0; i<xs.Length; i++)
                Claim.eq(even(i) ? 0xAA : 0x55,  xs[i]);
        }

        public void vreverse_256x32u()
        {
            var n = n256;

            var spec = CpuVector.parts(n256, 7u, 6u, 5u, 4u, 3u, 2u, 1u, 0u);       
            //Trace(spec.FormatDataProp("MRev256u32"));

            for(var i = 0; i< SampleCount; i++)
            {
                var x = Random.Blocks<uint>(n);
                var y = x.Replicate();
                y.Data.Reverse();
            
                var expect = CpuVector.vload(y);
                var actual = dinx.vreverse(x.LoadVector());
                Claim.eq(expect, actual);
            }
        }

        public static Vector256<int> vswap_ref(Vector256<int> src, byte i, byte j)
        {
            Span<uint> spec = stackalloc uint[Vector256<uint>.Count];
            for(byte k=0; k<spec.Length; k++)
            {
                if(k == i)        
                    spec[k] = j;
                else if(k == j)
                    spec[k] = i;
                else
                    spec[k] = k;
            }
            return dinx.vperm8x32(src,CpuVector.vload(n256, head(spec)));
        }

        public void swap_256_i32()
        {
            var subject = Vector256.Create(2, 4, 6, 8, 10, 12, 14, 16);
            var swapped = vswap_ref(subject, 2, 3);
            var expect = Vector256.Create(2, 4, 8, 6, 10, 12, 14, 16);
            Claim.eq(expect, swapped);
        }
    }
}