//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vmovemask : IntrinsicTest<t_vmovemask>
    {
        public void pack_test()
        {
            var x = dinx.vparts(n128,0,1,2,4,4,5,6,7);
            var y = dinx.vparts(n128,8,9,10,11,12,13,14,15);
            var z = dinx.vpackus(x,y);
            var e = dinx.vparts(n128,0,1,2,4,4,5,6,7,8,9,10,11,12,13,14,15);
            Claim.eq(e,z);
            
        }

        public void movemask_256x64u_examples()
        {
            var x = Random.CpuVector<uint>(n256);
            var y = x;
            Span<uint> m = new uint[8];
            for(var i=0; i<8; i++)
            {
                m[i] = ginx.vmovemask(x);
                x = ginx.vsll(x,1);
            }

            Trace(v8u(y).FormatBits());
            Trace(m.FormatBits());            

        }

        public void movemask_256x8u()
        {
            var bits = n256;
            var bytes = n32;
            var src = Random.BlockedSpan<byte>(n256, blocks:SampleSize);
            const int hibit = 7;

            for(var i=0; i<SampleSize; i++)
            {                
                var srcBlock = src.Block(i);
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
                
                var srcBlock = src.Block(i);
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

                var mmExpect = BitVector.alloc(n32);
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

                var mmExpect = BitVector.alloc(n32);
                for(byte r=0; r<srcVector.Length(); r++)
                    if(BitMask.test(srcSpan[r], 63))
                        mmExpect.Enable(r);
                
                var mmActual = dfp.vmovemask(srcVector).ToBitVector(n32);
                Claim.yea(mmExpect == mmActual);
            }
        }
    }
}