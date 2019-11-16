//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_varrange : IntrinsicTest<t_varrange>
    {     

        public void duplicate32x0_256x32u_basecase()
        {
            var n = n256;
            var width = n32;

            var x0 = dinx.vparts(n,0,1,2,3,4,5,6,7);
            var y0 = dinx.vduplicate(n0,width,x0);
            var z0 = dinx.vduplicate(n1,width,x0);
            Claim.eq(y0, dinx.vparts(n,0,0,2,2,4,4,6,6));
            Claim.eq(z0, dinx.vparts(n,1,1,3,3,5,5,7,7));            

            var x1 = dinx.vparts(n,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y1 = dinx.vduplicate(n0,width,x1);
            var z1 = dinx.vduplicate(n1,width,x1);
            Claim.eq(y1, dinx.vparts(n,0,1, 0,1, 4,5, 4,5, 8,9, 8,9, C,D, C,D));
            Claim.eq(z1, dinx.vparts(n,2,3, 2,3, 6,7, 6,7, A,B, A,B, E,F, E,F));
            
            var x2 = dinx.vparts(n,
                ulong.MaxValue & 0x55555555AAAAAAAA, 
                ulong.MaxValue & 0xCCCCCCCC88888888, 
                ulong.MaxValue & 0x3333333377777777,
                ulong.MaxValue & 0x2222222244444444);
            var y2 = dinx.vduplicate(n0,width,x2);
            var z2 = dinx.vduplicate(n1,width,x2);
        }
        
        public void reverse_128x8u_basecase()
        {
            var n = n128;
            var v1 = DataPatterns.increments<byte>(n);
            var v2 = DataPatterns.decrements<byte>(n);
            var v3 = dinx.vreverse(v1);
            Claim.eq(v2,v3);
        }

        public void reverse_256x8u_basecase()
        {
            var n = n256;
            var v1 = DataPatterns.increments<byte>(n);
            var v2 = DataPatterns.decrements<byte>(n);            
            var v3 = dinx.vreverse(v1);
            Claim.eq(v2,v3);

        }

        public void alt_256x8u_basecase()
        {
            var n = n256;
            var x = ginx.valt(n, 0xAA, 0x55);
            var xs = x.ToSpan();
            for(var i=0; i<xs.Length; i++)
                Claim.eq(even(i) ? 0xAA : 0x55,  xs[i]);
        }

        public void reverse_256x32u()
        {
            var n = n256;
            for(var i = 0; i< SampleSize; i++)
            {
                var x = Random.BlockedSpan<uint>(n);
                var y = x.Replicate();
                y.Reverse();
            
                var expect = ginx.vload(y);
                var actual = dinx.vreverse(x.LoadVector());
                Claim.eq(expect, actual);
            }
        }


        public void vperm4x32_128x32u_basecase()
        {
            var n = n128;

            var u = DataPatterns.increments<uint>(n);
            Claim.eq(dinx.vparts(n,0,1,2,3), u);

            var v = DataPatterns.decrements<uint>(n);
            Claim.eq(dinx.vparts(n,3,2,1,0),v);

            Claim.eq(v, dinx.vperm4x32(u, Perm4.DCBA));
            Claim.eq(u, dinx.vperm4x32(v, Perm4.DCBA));
        }


        public void vunpackhi_256x64u_basecase()
        {            
            var n = n256;
            var x = dinx.vparts(n,1,2,3,4);
            var y = dinx.vparts(n,5,6,7,8);
            var expect = dinx.vparts(n,2,6,4,8);
            var actual = dinx.vunpackhi(x,y);
            Claim.eq(expect, actual);
        }

        public void vunpackhi_256x32u_basecase()
        {
            var n = n256;
            var x = dinx.vparts(n,1u,2,3,4,5,6,7,8);
            var y = dinx.vparts(n,10u,12,13,14,15,16,17,18);
            var actual = dinx.vunpackhi(x,y);
            var expect = dinx.vparts(n, 3u,13,4,14,7,17,8,18);
            Claim.eq(expect, actual);
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
            return dinx.vperm8x32i(src,ginx.vload(n256, head(spec)));
        }

        public void swap_256_i32()
        {
            var subject = Vector256.Create(2, 4, 6, 8, 10, 12, 14, 16);
            var swapped = vswap_ref(subject, 2, 3);
            var expect = Vector256.Create(2, 4, 8, 6, 10, 12, 14, 16);
            Claim.eq(expect, swapped);
        }

        static string DescribeShuffle<T>(Vector256<T> src, byte spec, Vector256<T> dst)
            where T : unmanaged
        {
            var xFmt = src.FormatHex();
            var specFmt = spec.ToBitString();
            var dstFmt = dst.FormatHex();

            var fmt = sbuild();
            var dataType = typeof(T).DisplayName();
            fmt.AppendLine(new string(AsciSym.Minus, 80));
            fmt.AppendLine($"shuffle256:Vec256<{dataType}> -> spec:byte -> {specFmt}");
            fmt.AppendLine(xFmt);
            fmt.AppendLine(dstFmt);
            return fmt.ToString();
        }

        static string Describe2x128Perm<T>(Vector256<T> x, Vector256<T> y, byte spec, Vector256<T> dst)
            where T : unmanaged
        {
            var xFmt = x.FormatHex();
            var yFmt = y.FormatHex();
            var dstFmt = dst.Format();
            var specFmt = spec.ToBitString();
            var fmt = sbuild();
            var dataType = typeof(T).DisplayName();
            fmt.AppendLine(new string(AsciSym.Minus, 80));
            fmt.AppendLine($"permute2x128:Vec256<{dataType}> -> Vec256<{dataType}> -> {specFmt}");
            fmt.AppendLine(xFmt);
            fmt.AppendLine($"{yFmt}");
            fmt.AppendLine(dstFmt);
            return fmt.ToString();
        }
    }
}