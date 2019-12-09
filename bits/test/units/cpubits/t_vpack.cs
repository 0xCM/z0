//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_vpack : t_vcpu<t_vpack>
    {
        public void vpack_8x1x8()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var data = Random.Next<byte>();
                var bs = data.ToBitString();
                Claim.eq(8,bs.Length);
                var packed = CpuBits.vpack8x1(bs.BitSeq);
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
                var packed = CpuBits.vpack16x1(bs.BitSeq);
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
                var packed = CpuBits.vpack32x1(bs.BitSeq);
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
                CpuBits.vpack32x1(blocks, buffer);

                var bsY = buffer.ToBitString();
                Claim.eq(bsX,bsY);

                
            }
        }

    }

}