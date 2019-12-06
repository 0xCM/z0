//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;

    public class t_vpack : t_vinx<t_vpack>
    {
        public void pack32x1_basecase()
        {            
            const uint pattern = 0xFFFFFFFF;

            // 128 input values of type bit = 128x32 bytes, each of which are on
            var input = pattern.ToBitString().Replicate(4).ToBitSpan<N128>();
            
            // 128 bits of output which represents the packing of 128 source bits, each of shich should be on
            var output = SimdPack.pack(input);
            
            Claim.eq(ginx.vones<uint>(n128), output);            
        }

        public void pack8_basecase()
        {
            var src = NatSpan.parts(n8,1u,0u,1u,1u,1u,0u,0u,0u);            
            var dst = AvxBitpack.pack(src,0);
            Trace(src.FormatBits());
            Trace(dst.FormatBits());
        }

        public void pack32()
        {
            var n = n32;

            var bits = Random.BitSpan(n);
            var src = NatSpan.alloc(n,0u);
            for(var i=0; i<src.Length; i++)
                src[i] = (uint)bits[i];

            var dst = AvxBitpack.pack(src,0);
            
        
            
            Trace(bits.FormatBits());
            Trace(src.FormatBits());
            Trace(dst.FormatBits());
            
        }

        static int pop(ReadOnlySpan<bit> src)
        {
            var count = 0;
            for(var i=0; i<src.Length; i++)
                count += (int)src[i];            
            return count;
        }

        public void pack32x1_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var input = Random.BitSpan(n128);            
                var popin = pop(input);            
                var output = SimdPack.pack(input);
                var popout = output.ToBitString().PopCount();
                Claim.eq(popout,popin);
            }            
        }
    }
}