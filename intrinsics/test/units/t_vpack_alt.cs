//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_vpack_alt : t_vinx<t_vpack_alt>
    {
        /// <summary>
        /// Packs 32 1-bit values
        /// </summary>
        [MethodImpl(Inline)]
        public static uint vpack32x1(ReadOnlySpan<byte> src)
        {
            var x = v64u(ginx.vload(n256, in head(src)));
            x = ginx.vsll(x,7);
            return ginx.vtakemask(x);
        }

        /// <summary>
        /// Pack 16 1-bit values
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline)]
        public static ushort vpack16x1(ReadOnlySpan<byte> src)
        {
            var x = v64u(ginx.vload(n128, in head(src)));
            x = ginx.vsll(x,7);
            return ginx.vtakemask(x);
        }

        /// <summary>
        /// Pack 8 1-bit values
        /// </summary>
        /// <param name="src">The source bytes</param>
        [MethodImpl(Inline)]
        public static byte vpack8x1(ReadOnlySpan<byte> src)
        {
            var x = ginx.vscalar(n128, head64(src));
            x = ginx.vsll(x,7);
            return (byte)ginx.vtakemask(x);
        }

        /// <summary>
        /// Packs 32 1-bit values from each block
        /// </summary>
        /// <param name="src">The pack source</param>
        /// <param name="dst">The pack target</param>
        [MethodImpl(Inline)]
        public static void vpack32x1(in ConstBlock256<byte> src, Span<uint> dst)
        {
            ref var target = ref head(dst);
            var blocks = math.min(src.BlockCount,dst.Length);
            for(var i=0; i<blocks; i++)
                seek(ref target, i) = ginx.vtakemask(ginx.vsll(src.LoadVector(i),7));                
        }

        public void vpack_8x1x8()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var data = Random.Next<byte>();
                var bs = data.ToBitString();
                Claim.eq(8,bs.Length);
                var packed = vpack8x1(bs.BitSeq);
                Claim.eq(data,packed);
            }
        }

        public void vpack_16x1x8()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var data = Random.Next<ushort>();
                var bs = data.ToBitString();
                Claim.eq(16,bs.Length);
                var packed = vpack16x1(bs.BitSeq);
                Claim.eq(data,packed);
            }
        }

        public void vpack_32x1x8()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var data = Random.Next<uint>();
                var bs = data.ToBitString();
                Claim.eq(32,bs.Length);
                var packed = vpack32x1(bs.BitSeq);
                Claim.eq(data,packed);
            }
        }

        public void vpack_blocks_32x1x8()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var bsX = Random.BitString(32*4);
                var blocks = DataBlocks.checkedload(n256, bsX.BitSeq);
                Claim.eq(blocks.BlockCount,4);

                Span<uint> buffer = new uint[4];
                vpack32x1(blocks, buffer);

                var bsY = buffer.ToBitString();
                Claim.eq(bsX,bsY);

                
            }
        }

    }

}