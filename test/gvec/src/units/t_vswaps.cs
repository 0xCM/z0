//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public class t_vswaps : t_inx<t_vswaps>
    {
        public void vswap_128x8u()
        {
            var src = gvec.vinc(n128, z8);
            var dst = z.vswap(src,2,3);
            Claim.eq(src.Cell(2), dst.Cell(3));
            Claim.eq(src.Cell(3), dst.Cell(2));
        }

        public void vswap_128x16u()
        {
            var src = gvec.vinc(n128, z16);
            var dst = z.vswap(src,2,3);
            Claim.eq(src.Cell(2), dst.Cell(3));
            Claim.eq(src.Cell(3), dst.Cell(2));
        }

        public void transpose_4x4_check()
        {
            var order = n4;
            var n = n128;
            var cells = order*order;
            var src = SpanBlocks.alloc<uint>(n,order);
            int step = order;

            for(var i=0; i< cells; i++)
                src[i] = (uint)i;

            var a = src.LoadVector(0);
            var b = src.LoadVector(1);
            var c = src.LoadVector(2);
            var d = src.LoadVector(3);
            z.vtranspose(ref a, ref b, ref c, ref d);


            var dst = new uint[cells];
            cpu.vstore(a, ref head(dst), step*0);
            cpu.vstore(b, ref head(dst), step*1);
            cpu.vstore(c, ref head(dst), step*2);
            cpu.vstore(d, ref head(dst), step*3);

            var A = Matrix.load(order, src.Storage.ToArray());
            var B = Matrix.load(order, dst);
            for(var i=0; i < order; i++)
            for(var j=0; j < order; j++)
                Claim.eq(A[i,j], B[j,i]);
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
            return z.vperm8x32(src, cpu.vload(n256, first(spec)));
        }

        public void swap_256_i32()
        {
            var subject = Vector256.Create(2, 4, 6, 8, 10, 12, 14, 16);
            var swapped = vswap_ref(subject, 2, 3);
            var expect = Vector256.Create(2, 4, 8, 6, 10, 12, 14, 16);
            Claim.veq(expect, swapped);
        }
    }
}