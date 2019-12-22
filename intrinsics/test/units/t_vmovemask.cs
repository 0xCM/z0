//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vtakemask : t_vinx<t_vtakemask>
    {
        public void vtakemask_outline()
        {
            void case1()
            {
                var x = CpuVector.broadcast(n256, (byte)Pow2.T07);
                var m = ginx.vtakemask(x);
                Claim.eq(uint.MaxValue,m);
            }

            void case2()
            {
                var x = Random.CpuVector<uint>(n256);
                var y = x;
                Span<uint> m = new uint[8];
                for(var i=0; i<8; i++)
                {
                    m[i] = ginx.vtakemask(x);
                    x = ginx.vsll(x,1);
                }
            }

            case1();
            case2();
        }

        public void vtakemask_256x8u()
        {
            var bits = n256;
            var bytes = n32;
            var src = Random.Blocks<byte>(n256, count:SampleSize);
            const int hibit = 7;

            for(var i=0; i<SampleSize; i++)
            {                
                var srcCpuVec = src.LoadVector(i);
                var srcBitVec = srcCpuVec.ToSpan().ToBitCells(bits);
                
                Claim.eq(bits, srcBitVec.BitCount);
                Claim.eq(srcCpuVec.ToBitString().ToBits().ToBitString(), srcBitVec.ToBitString());
                                                
                var mask = 0u;
                for(var r=0; r<srcCpuVec.Length(); r++)
                    if(BitMask.testbit(src[i,r], hibit))
                        mask = BitMask.enable(mask, r);
                
                var expect = mask.ToBitVector().ToBitString();
                var actual = dinx.vtakemask(srcCpuVec).ToBitVector().ToBitString();
                Claim.eq(expect, actual);
            }
        }

        public void vtakemask_128x8u()
        {
            const int hibit = 7;
            var bits = n128;
            var bytes = n16;
            var src = Random.Blocks<byte>(bits, count:SampleSize);

            for(var i=0; i<SampleSize; i++)
            {
                
                var srcCpuVec = src.LoadVector(i);
                var srcBitVec = srcCpuVec.ToSpan().ToBitCells(bits);
                
                Claim.eq(bits, srcBitVec.BitCount);
                Claim.eq(srcCpuVec.ToBitString().ToBits().ToBitString(), srcBitVec.ToBitString());
                                                
                var mask = 0u;
                for(var r=0; r<srcCpuVec.Length(); r++)
                    if(BitMask.testbit(src[i,r], hibit))
                        mask = BitMask.enable(mask, r);
                
                var expect = mask.ToBitVector(bytes).ToBitString();
                var actual = dinx.vtakemask(srcCpuVec).ToBitVector().ToBitString();
                Claim.eq(expect, actual);
            }
        }

        public void vtakemask_256x32f()
        {
            var samples = Pow2.T12;
            var src = Random.Blocks<float>(n256,samples);
            for(var i=0; i<samples; i++)
            {
                var srcVector = src.LoadVector(i);
                var srcSpan = srcVector.ToSpan();

                var mmExpect = BitVector.alloc(n32);
                for(byte r=0; r<srcVector.Length(); r++)
                    if(BitMask.testbit(srcSpan[r], 31))
                        BitVector.enable(mmExpect,r);
                
                var mmActual = fpinx.takemask(srcVector).ToBitVector();
                Claim.yea(mmExpect == mmActual);
            }
        }

        public void vtakemask_256x64f()
        {
            var samples = Pow2.T12;
            var src = Random.Blocks<double>(n256, samples);
            for(var i=0; i<samples; i++)
            {
                var srcVector = src.LoadVector(i);
                var srcSpan = srcVector.ToSpan();

                var mmExpect = BitVector.alloc(n32);
                for(byte r=0; r<srcVector.Length(); r++)
                    if(BitMask.testbit(srcSpan[r], 63))
                        BitVector.enable(mmExpect,r);
                
                var mmActual = fpinx.takemask(srcVector).ToBitVector();
                Claim.yea(mmExpect == mmActual);
            }
        }
    }
}