//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vmovemask : t_vinx<t_vmovemask>
    {

        public void makemask_128()
        {

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.BitVector(n16);
                var z = dinx.vtakemask(dinx.vmakemask(x));
                Claim.eq(z,x);
            }

        }

        public void makemask_256()
        {

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.BitVector(n32);
                var z = dinx.vtakemask(dinx.vmakemask(x));
                Claim.eq(z,x);

            }

        }


        public void pack_test()
        {
            var x = vbuild.parts(n128,0,1,2,4,4,5,6,7);
            var y = vbuild.parts(n128,8,9,10,11,12,13,14,15);
            var z = dinx.vpackus(x,y);
            var e = vbuild.parts(n128,0,1,2,4,4,5,6,7,8,9,10,11,12,13,14,15);
            Claim.eq(e,z);
            
        }

        public void movemask_256x64u_examples()
        {
            var x = Random.CpuVector<uint>(n256);
            var y = x;
            Span<uint> m = new uint[8];
            for(var i=0; i<8; i++)
            {
                m[i] = ginx.vtakemask(x);
                x = ginx.vsll(x,1);
            }

            Trace(v8u(y).FormatBits());
            Trace(m.FormatBits());            

        }
        // 4x64
        // [A0 A1 A2 A3 A4 A5 A6 A7]
        // [B0 B1 B2 B3 B4 B5 B6 B7]
        // [C0 C1 C2 C3 C4 C5 C6 C7]
        // [D0 D1 D2 D3 D4 D5 D6 D7]
        public void vgather_movemask()
        {
            var n = n256;
            var w = n1024;
            var ix = n256;
            var pattern = vbuild.vbroadcast(n, 0b00010001_00010001_00010001_00010001u);

            var data = span(range<uint>(0,(uint)(w-1)));
            Claim.eq(data.Length, w);

            ref var src = ref head(data);

            // for(var i=0; i< w; i+=8)
            //     ginx.vstore(pattern, ref src, i);

            // for(var i=0; i < w; i+= 8)
            //     Claim.eq(pattern,ginx.vload(n, in src, i));                


        }

        public void movemask_256x8u()
        {
            var bits = n256;
            var bytes = n32;
            var src = Random.Blocks<byte>(n256, blocks:SampleSize);
            const int hibit = 7;

            for(var i=0; i<SampleSize; i++)
            {                
                var srcCpuVec = src.LoadVector(i);
                var srcBitVec = srcCpuVec.ToSpan().ToBitCells(bits);
                
                Claim.eq(bits, srcBitVec.BitCount);
                Claim.eq(srcCpuVec.ToBitString().ToBitSpan().ToBitString(), srcBitVec.ToBitString());
                                                
                var mask = 0u;
                for(var r=0; r<srcCpuVec.Length(); r++)
                    if(BitMask.testbit(src[i,r], hibit))
                        mask = BitMask.enable(mask, r);
                
                var expect = mask.ToBitVector().ToBitString();
                var actual = dinx.vtakemask(srcCpuVec).ToBitVector().ToBitString();
                Claim.eq(expect, actual);
            }
        }

        public void movemask_128x8u()
        {
            const int hibit = 7;
            var bits = n128;
            var bytes = n16;
            var src = Random.Blocks<byte>(bits, blocks:SampleSize);

            for(var i=0; i<SampleSize; i++)
            {
                
                var srcCpuVec = src.LoadVector(i);
                var srcBitVec = srcCpuVec.ToSpan().ToBitCells(bits);
                
                Claim.eq(bits, srcBitVec.BitCount);
                Claim.eq(srcCpuVec.ToBitString().ToBitSpan().ToBitString(), srcBitVec.ToBitString());
                                                
                var mask = 0u;
                for(var r=0; r<srcCpuVec.Length(); r++)
                    if(BitMask.testbit(src[i,r], hibit))
                        mask = BitMask.enable(mask, r);
                
                var expect = mask.ToBitVector(bytes).ToBitString();
                var actual = dinx.vtakemask(srcCpuVec).ToBitVector().ToBitString();
                Claim.eq(expect, actual);
            }
        }

        public void movemask_256x32f()
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
                
                var mmActual = fpinx.vmovemask(srcVector).ToBitVector();
                Claim.yea(mmExpect == mmActual);
            }
        }

        public void movemask_256x64f()
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
                
                var mmActual = fpinx.vmovemask(srcVector).ToBitVector();
                Claim.yea(mmExpect == mmActual);
            }
        }
    }
}