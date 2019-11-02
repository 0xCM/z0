//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
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

        public void shuffle_128x32i()
        {
            var u = ginx.vincrements<int>(n128);
            Claim.eq(Vector128.Create(0,1,2,3), u);

            var v = ginx.vdecrements<int>(n128,3);
            Claim.eq(Vector128.Create(3,2,1,0),v);

            Claim.eq(v, dinx.vshuffle(u, Perm4.DCBA));
            Claim.eq(u, dinx.vshuffle(v, Perm4.DCBA));
        }

        public void reverse_256x8u()
        {
            var inc = Vec256Pattern.increments((byte)0);
            var dec = Vec256Pattern.decrements((byte)31);            
            var v2 = dinx.vreverse(inc);
            Claim.eq(dec,v2);

        }

        public void reverse_256x32u()
        {
            for(var i = 0; i< SampleSize; i++)
            {
                var data = Random.BlockedSpan<uint>(n256);
                var expect = Vector256.Create(data[7],data[6],data[5],data[4],data[3],data[2],data[1],data[0]);
                var actual = dinx.vreverse(data.LoadVector());
                Claim.eq(expect, actual);
            }
        }

        public void reverse_256x32f()
        {
            for(var i = 0; i< SampleSize; i++)
            {
                var data = Random.BlockedSpan<float>(n256);
                var expect = Vector256.Create(data[7],data[6],data[5],data[4],data[3],data[2],data[1],data[0]);
                var actual = dinx.vreverse(data.LoadVector());
                Claim.eq(expect, actual);
            }
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
            var x = dinx.vparts(1u, 2u,  3u,4u,   5u,6u,   7u,8u);
            var y = dinx.vparts(10u,12u, 13u,14u, 15u,16u, 17u,18u);

            var actual = dinx.vunpackhi(x,y);
            var expect = dinx.vparts(3u,13u,4u,14u,7u,17u,8u,18u);
            Claim.eq(expect, actual);
        }

        public void swap_256_i32()
        {
            var subject = Vector256.Create(2, 4, 6, 8, 10, 12, 14, 16);
            var swapped = dinx.vswap_ref(subject, 2, 3);
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
                var v3 = dinx.vblendv(v0,v1, mask);
                
                var selection = Span256.AllocBlocks<byte>(1);
                for(var i=0; i< selection.Length; i++)
                    selection[i] = bits[i] ? v1s[i] : v0s[i];
                var v4 =  selection.TakeVector();            
                
                Claim.eq(v3, v4);
            }

            Verify(Test1);

            var v1 = ginx.vbroadcast<byte>(n256,3);
            var v2 = ginx.vbroadcast<byte>(n256,4);
            var control = Vec256Pattern.alternating<byte>(0, 0xFF);
            var v3 = dinx.vblendv(v1,v2, control);
            var block = Span256.AllocBlocks<byte>(1);
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

        static Vector128<ushort> reverse_check(Vector128<ushort> src)
            => dinx.vshufflelo(dinx.vshufflehi(src, 0b00_01_10_11), 0b00_01_10_11);
    }

}