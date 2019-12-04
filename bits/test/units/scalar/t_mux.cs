//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_sb_mux : t_sb<t_sb_mux>
    {
        public void mux_4()
        {            
            for(var i=0; i< SampleSize; i++)
            {
                var input = Random.BitSpan(4);
                bit i0 = input[0], i1 = input[1], i2 = input[2], i3 = input[3];

                var out0 = Mux.mux(off, off, i0, i1, i2, i3);
                var out1 = Mux.mux(on,  off, i0, i1, i2, i3);
                var out2 = Mux.mux(off, on, i0, i1, i2, i3);
                var out3 = Mux.mux(on,  on, i0, i1, i2, i3);
                
                Claim.eq(i0, out0);
                Claim.eq(i1, out1);
                Claim.eq(i2, out2);
                Claim.eq(i3, out3);
            }
        }

        public void mux_8()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var iv = Random.BitVector(n8);
                var ov = BitVector8.Zero;
                var cv = BitVector4.Zero;
                ov[0] = Mux.mux(cv, iv);
                ov[1] = Mux.mux(++cv, iv);
                ov[2] = Mux.mux(++cv, iv);
                ov[3] = Mux.mux(++cv, iv);
                ov[4] = Mux.mux(++cv, iv);
                ov[5] = Mux.mux(++cv, iv);
                ov[6] = Mux.mux(++cv, iv);
                ov[7] = Mux.mux(++cv, iv);
                Claim.eq(iv,ov);                
            }
        }

        public void mux_16()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var input = Random.BitVector(n16);
                var control = Random.BitVector(n4);
                var output = Mux.mux(control,input);
                var expect = input[control.Scalar];
                Claim.eq(expect, output);                                
            }

        }

        public void mux_32()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var input = Random.BitVector(n32);
                var control = Random.BitVector(n8) & 0b11111;
                var output = Mux.mux(control,input);
                var expect = input[control.Scalar];
                Claim.eq(expect, output);                                
            }
        }

        public void mux_64()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var input = Random.BitVector(n64);
                var control = Random.BitVector(n8) & 0b111111;
                var output = Mux.mux(control,input);
                var expect = input[control.Scalar];
                Claim.eq(expect, output);                                
            }

        }
    }
}
