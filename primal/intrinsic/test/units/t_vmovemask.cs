//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;

    public class t_vmovemask : UnitTest<t_vmovemask>
    {
        public void movemask_256x8u()
        {
            var bits = n256;
            var bytes = n32;
            var src = Random.BlockedSpan<byte>(n256, blocks:SampleSize);
            const int hibit = 7;

            for(var i=0; i<SampleSize; i++)
            {                
                var srcBlock = src.Blocked(i);
                var srcCpuVec = src.LoadVector(i);
                var srcBitVec = srcCpuVec.ToSpan().ToBitCells(bits);
                
                Claim.eq(bits, srcBitVec.Length);
                Claim.eq(srcCpuVec.ToBitString().ToBitSpan().ToBitString(), srcBitVec.ToBitString());
                                                
                var mask = 0u;
                for(var r=0; r<srcCpuVec.Length(); r++)
                    if(BitMask.test(srcBlock[r], hibit))
                        BitMask.enable(ref mask, r);
                
                var expect = mask.ToBitVector(bytes).ToBitString();
                var actual = dinx.vmovemask(srcCpuVec).ToBitVector(bytes).ToBitString();
                Claim.eq(expect, actual);
            }
        }

        public void movemask_128x8u()
        {
            const int hibit = 7;
            var bits = n128;
            var bytes = n16;
            var src = Random.BlockedSpan<byte>(bits, blocks:SampleSize);

            for(var i=0; i<SampleSize; i++)
            {
                
                var srcBlock = src.Blocked(i);
                var srcCpuVec = src.LoadVector(i);
                var srcBitVec = srcCpuVec.ToSpan().ToBitCells(bits);
                
                Claim.eq(bits, srcBitVec.Length);
                Claim.eq(srcCpuVec.ToBitString().ToBitSpan().ToBitString(), srcBitVec.ToBitString());
                                                
                var mask = 0u;
                for(var r=0; r<srcCpuVec.Length(); r++)
                    if(BitMask.test(srcBlock[r], hibit))
                        BitMask.enable(ref mask, r);
                
                var expect = mask.ToBitVector(bytes).ToBitString();
                var actual = dinx.vmovemask(srcCpuVec).ToBitVector(bytes).ToBitString();
                Claim.eq(expect, actual);
            }
        }

        public void movemask_256x32f()
        {
            var samples = Pow2.T12;
            var src = Random.BlockedSpan<float>(n256,samples);
            for(var i=0; i<samples; i++)
            {
                var srcVector = src.TakeVector(i);
                var srcSpan = srcVector.ToSpan();

                var mmExpect = BitVector32.Alloc();
                for(byte r=0; r<srcVector.Length(); r++)
                    if(BitMask.test(srcSpan[r], 31))
                        mmExpect.Enable(r);
                
                var mmActual = dfp.vmovemask(srcVector).ToBitVector(n32);
                Claim.yea(mmExpect == mmActual);
            }
        }


        public void movemask_256x64f()
        {
            var samples = Pow2.T12;
            var src = Random.BlockedSpan<double>(n256, samples);
            for(var i=0; i<samples; i++)
            {
                var srcVector = src.TakeVector(i);
                var srcSpan = srcVector.ToSpan();

                var mmExpect = BitVector32.Alloc();
                for(byte r=0; r<srcVector.Length(); r++)
                    if(BitMask.test(srcSpan[r], 63))
                        mmExpect.Enable(r);
                
                var mmActual = dfp.vmovemask(srcVector).ToBitVector(n32);
                Claim.yea(mmExpect == mmActual);
            }
        }
    }
}