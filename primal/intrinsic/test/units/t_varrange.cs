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
        public void shift128()
        {
            var src = ginx.vpOnes<ulong>(n128);
            const byte offset = 19;
            var y = ginx.vsllx(src,offset);
            var z = ginx.vsrlx(src,offset);
            

            Trace(src.ToBitString());
            Trace(src.ToBitString().Sll(offset).Format());
            Trace(y.ToBitString());
            Trace(z.ToBitString());
        }

        public void reverse_128x8u()
        {
            var v1 = Vec128Pattern.Increments<byte>(0);
            var v2 = Vec128Pattern.Decrements<byte>(15);
            var v3 = dinx.reverse(v1);
            Claim.eq(v2,v3);
        }

        public void shuffle_128x32i()
        {
            var u = ginx.vpIncrements<int>(n128);
            Claim.eq(Vector128.Create(0,1,2,3), u);

            var v = Vec128Pattern.Decrements<int>(3);
            Claim.eq(Vector128.Create(3,2,1,0),v);

            Claim.eq(v, dinx.vshuffle(u, Perm4.DCBA));
            Claim.eq(u, dinx.vshuffle(v, Perm4.DCBA));
        }

        public void reverse_256x8u()
        {
            var inc = Vec256Pattern.Increments((byte)0);
            var dec = Vec256Pattern.Decrements((byte)31);            
            var v2 = dinx.reverse(inc);
            Claim.eq(dec,v2);

        }

        public void reverse_256x32u()
        {
            var src = Random.CpuVec256Stream<uint>().Take(Pow2.T14);
            foreach(var v in src)
            {
                var expect = Vector256.Create(v[7],v[6],v[5],v[4],v[3],v[2],v[1],v[0]);
                var actual = dinx.reverse(v);                
                Claim.eq(expect, actual);
            }
        }

        public void reverse_256x32f()
        {
            var src = Random.CpuVec256Stream<float>().Take(Pow2.T14);
            foreach(var v in src)
            {
                var expect = Vector256.Create(v[7],v[6],v[5],v[4],v[3],v[2],v[1],v[0]);
                var actual = dinx.reverse(v);
                Claim.eq(expect, actual);
            }
        }

        public void hi_256_u64()
        {            
            var x = v256(1ul,2ul,3ul,4ul);
            var y = v256(5ul,6ul,7ul,8ul);
            var expect = v256(2ul,6ul,4ul,8ul);

            var actual = dinx.vunpackhi(x,y);
            Claim.eq(expect, actual);
        }

        public void hi_256_u32()
        {
            var x = Vec256.FromParts(1u, 2u,  3u,4u,   5u,6u,   7u,8u);
            var y = Vec256.FromParts(10u,12u, 13u,14u, 15u,16u, 17u,18u);

            var actual = dinx.vunpackhi(x,y);
            var expect = Vec256.FromParts(3u,13u,4u,14u,7u,17u,8u,18u);
            Claim.eq(expect, actual);
        }

        public void swap_256_i32()
        {
            var subject = Vec256.FromParts(2, 4, 6, 8, 10, 12, 14, 16);
            var swapped = dinx.vswap_ref(subject, 2, 3);
            var expect = Vec256.FromParts(2, 4, 8, 6, 10, 12, 14, 16);
            Claim.eq(expect, swapped);
        }

        public void blend_256_u8()
        {
            var n = n256;
            void Test1()
            {
                var v0 = Random.CpuVec256<byte>();
                var v1 = Random.CpuVec256<byte>();
                var bits = Random.BitString<N32>();
                var mask = Vec256.Load(bits.Map(x => x ? (byte)0xFF : (byte)0));
                var v3 = dinx.vblendvar(v0,v1, mask);
                
                var selection = Span256.AllocBlocks<byte>(1);
                for(var i=0; i< selection.Length; i++)
                    selection[i] = bits[i] ? v1[i] : v0[i];
                var v4 =  selection.ToCpuVec256();            
                
                Claim.eq(v3, v4);
            }

            Verify(Test1);

            var v1 = Vec256.Fill<byte>(3);
            var v2 = Vec256.Fill<byte>(4);
            var control = Vec256Pattern.Alternate<byte>(0, 0xFF);
            var v3 = dinx.vblendvar(v1,v2, control);
            var block = Span256.AllocBlocks<byte>(1);
            for(var i=0; i<32; i++)
                block[i] = (byte) (even(i) ? 3 : 4);
            var v4 = block.ToCpuVec256();
            Claim.eq(v3, v4);

        }

        static string DescribeShuffle<T>(Vec256<T> src, byte spec, Vec256<T> dst)
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

        static string Describe2x128Perm<T>(Vec256<T> x, Vec256<T> y, byte spec, Vec256<T> dst)
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