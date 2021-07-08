//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public class t_mux : t_bits<t_mux>
    {
        bit on => bit.On;

        bit off => bit.Off;

        public void mux_4()
        {
            for(var i=0; i< RepCount; i++)
            {
                var input = Random.BitStream32().Take(4).ToArray();
                bit i0 = input[0], i1 = input[1], i2 = input[2], i3 = input[3];

                var out0 = bit.mux(i0, i1, i2, i3, off, off);
                var out1 = bit.mux(i0, i1, i2, i3, on,  off);
                var out2 = bit.mux(i0, i1, i2, i3, off, on);
                var out3 = bit.mux(i0, i1, i2, i3, on,  on);

                Claim.eq(i0, out0);
                Claim.eq(i1, out1);
                Claim.eq(i2, out2);
                Claim.eq(i3, out3);
            }
        }

        public void mux_8()
        {
            for(var i=0; i< RepCount; i++)
            {
                var iv = Random.BitVector(n8);
                var ov = BitVector8.Zero;
                var cv = BitVector4.Zero;
                ov[0] = BitVector.mux(iv,cv);
                ov[1] = BitVector.mux(iv, ++cv);
                ov[2] = BitVector.mux(iv, ++cv);
                ov[3] = BitVector.mux(iv, ++cv);
                ov[4] = BitVector.mux(iv, ++cv);
                ov[5] = BitVector.mux(iv, ++cv);
                ov[6] = BitVector.mux(iv, ++cv);
                ov[7] = BitVector.mux(iv, ++cv);
                Claim.eq(iv.Content,ov.Content);
            }
        }

        public void mux_16()
        {
            for(var i=0; i<RepCount; i++)
            {
                var input = Random.BitVector(n16);
                var control = Random.BitVector(n4);
                var output = BitVector.mux(input,control);
                var expect = input[control.Content];
                Claim.eq(expect, output);
            }
        }

        public void mux_32()
        {
            for(var i=0; i<RepCount; i++)
            {
                var input = Random.BitVector(n32);
                var control = Random.BitVector(n8) & 0b11111;
                var output = BitVector.mux(input,control);
                var expect = input[control.Content];
                Claim.eq(expect, output);
            }
        }

        public void mux_64()
        {
            for(var i=0; i<RepCount; i++)
            {
                var input = Random.BitVector(n64);
                var control = Random.BitVector(n8) & 0b111111;
                var output = bit.mux(input,control);
                var expect = input[control.Content];
                Claim.eq(expect, output);
            }
        }
    }
}