//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_varrange : IntrinsicTest<t_varrange>
    {     

        public void reverse_128x8u()
        {
            var v1 = ginx.vincrements<byte>(n128);
            var v2 = ginx.vdecrements<byte>(n128,15);
            var v3 = dinx.vreverse(v1);
            Claim.eq(v2,v3);
        }

        public void reverse_256x8u()
        {
            var inc = ginx.vincrements(n256, (byte)0);
            var dec = ginx.vdecrements(n256, (byte)31);            
            var v2 = dinx.vreverse(inc);
            Claim.eq(dec,v2);

        }

        public void reverse_256x32u()
        {
            for(var i = 0; i< SampleSize; i++)
            {
                var x = Random.BlockedSpan<uint>(n256);
                var y = x.Replicate();
                y.Reverse();
            
                var expect = ginx.vload(y);
                var actual = dinx.vreverse(x.LoadVector());
                Claim.eq(expect, actual);
            }
        }


        public void shuffle_128x32u()
        {
            var u = ginx.vincrements<uint>(n128);
            Claim.eq(dinx.vparts(0,1,2,3), u);

            var v = ginx.vdecrements<uint>(n128,3);
            Claim.eq(dinx.vparts(3,2,1,0),v);

            Claim.eq(v, dinx.vperm4x32(u, Perm4.DCBA));
            Claim.eq(u, dinx.vperm4x32(v, Perm4.DCBA));
        }



        public void hi_256_u64()
        {            
            var x = dinx.vparts(1ul,2ul,3ul,4ul);
            var y = dinx.vparts(5ul,6ul,7ul,8ul);
            var expect = dinx.vparts(2ul,6ul,4ul,8ul);

            var actual = dinx.vunpackhi(x,y);
            Claim.eq(expect, actual);
        }

        public void hi_256_u32()
        {
            var x = dinx.vparts(n256, 1u, 2u,  3u,4u,   5u,6u,   7u,8u);
            var y = dinx.vparts(n256, 10u,12u, 13u,14u, 15u,16u, 17u,18u);

            var actual = dinx.vunpackhi(x,y);
            var expect = dinx.vparts(n256, 3u,13u,4u,14u,7u,17u,8u,18u);
            Claim.eq(expect, actual);
        }

        public static Vector256<int> vswap_ref(Vector256<int> src, byte i, byte j)
        {
            Span<int> control = stackalloc int[Vector256<int>.Count];
            for(byte k=0; k<control.Length; k++)
            {
                if(k == i)        
                    control[k] = j;
                else if(k == j)
                    control[k] = i;
                else
                    control[k] = k;
            }
            return dinx.vperm8x32(src,ginx.vload(n256, head(control)));
        }


        public void swap_256_i32()
        {
            var subject = Vector256.Create(2, 4, 6, 8, 10, 12, 14, 16);
            var swapped = vswap_ref(subject, 2, 3);
            var expect = Vector256.Create(2, 4, 8, 6, 10, 12, 14, 16);
            Claim.eq(expect, swapped);
        }

        public void blend_256_u8()
        {
            var n = n256;
            void Test1()
            {
                var v0 = Random.CpuVector<byte>(n);
                var v1 = Random.CpuVector<byte>(n);
                var v1s = v1.ToSpan();
                var v0s = v0.ToSpan();
                var bits = Random.BitString<N32>();
                var bitmap = bits.Map(x => x ? (byte)0xFF : (byte)0);
                var mask = ginx.vload(n, in head(bitmap));
                var v3 = dinx.vblend32x8(v0,v1, mask);
                
                var selection = Span256.alloc<byte>(1);
                for(var i=0; i< selection.Length; i++)
                    selection[i] = bits[i] ? v1s[i] : v0s[i];
                var v4 =  selection.TakeVector();            
                
                Claim.eq(v3, v4);
            }

            Verify(Test1);

            var v1 = ginx.vbroadcast<byte>(n256,3);
            var v2 = ginx.vbroadcast<byte>(n256,4);
            var control = ginx.valt<byte>(n256, 0, 0xFF);
            var v3 = dinx.vblend32x8(v1,v2, control);
            var block = Span256.alloc<byte>(1);
            for(var i=0; i<32; i++)
                block[i] = (byte) (even(i) ? 3 : 4);
            var v4 = block.TakeVector();
            Claim.eq(v3, v4);

        }

        static string DescribeShuffle<T>(Vector256<T> src, byte spec, Vector256<T> dst)
            where T : unmanaged
        {
            var xFmt = src.FormatHexBlocks();
            var specFmt = spec.ToBitString();
            var dstFmt = dst.FormatHexBlocks();

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
            var xFmt = x.FormatHexBlocks();
            var yFmt = y.FormatHexBlocks();
            var dstFmt = dst.FormatHexBlocks();
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