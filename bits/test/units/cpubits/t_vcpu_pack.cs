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
        public void vcpu_pack_basecase()
        {            
            Span<byte> src1 = new byte[16];
            for(var i=0; i<src1.Length; i++)
                src1[i] = 1;
            
            var dst1 = CpuBits.vpack16x1x8(src1);
            Claim.eq(dst1, (uint)ushort.MaxValue);

            Span<byte> src2 = new byte[32];
            for(var i=0; i<src2.Length; i++)
                src2[i] = 1;

            var dst2 = CpuBits.vpack32x1x8(src2);
            Claim.eq(dst2, uint.MaxValue);
        }
    }

}