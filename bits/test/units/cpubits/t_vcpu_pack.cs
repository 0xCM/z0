//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_vcpu_pack : t_vcpu<t_vcpu_pack>
    {
        public void vcpu_pack_8x1x8()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var data = Random.Next<byte>();
                var bs = data.ToBitString();
                Claim.eq(8,bs.Length);
                var packed = CpuBits.vpack8x1x8(bs.BitSeq);
                Claim.eq(data,packed);
            }
        }

        public void vcpu_pack_16x1x8()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var data = Random.Next<ushort>();
                var bs = data.ToBitString();
                Claim.eq(16,bs.Length);
                var packed = CpuBits.vpack16x1x8(bs.BitSeq);
                Claim.eq(data,packed);
            }
        }

        public void vcpu_pack_32x1x8()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var data = Random.Next<uint>();
                var bs = data.ToBitString();
                Claim.eq(32,bs.Length);
                var packed = CpuBits.vpack32x1x8(bs.BitSeq);
                Claim.eq(data,packed);
            }
        }

    }

}