//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class t_full_adder : UnitTest<t_full_adder>
    {
        Bit32 on => Bit32.On;

        Bit32 off => Bit32.Off;

        public void fulladder_logical()
        {
            FullAdder.Compute(off, off, off, out Bit32 s0, out Bit32 c0);
            Claim.eq(s0, off);
            Claim.eq(c0, off);

            FullAdder.Compute(on, off, off, out Bit32 s1, out Bit32 c1);
            Claim.eq(s1, on);
            Claim.eq(c1, off);

            FullAdder.Compute(on, on, off, out Bit32 s2, out Bit32 c2);
            Claim.eq(s2, off);
            Claim.eq(c2, on);

            FullAdder.Compute(on, on, on, out Bit32 s3, out Bit32 c3);
            Claim.eq(s3, on);
            Claim.eq(c3, on);

            FullAdder.Compute(off, off, on, out Bit32 s4, out Bit32 c4);
            Claim.eq(s4, on);
            Claim.eq(c4, off);
        }

        public void vfulladder_256x64u()
        {
            var x = Random.CpuVector<ulong>(n256);
            var y = Random.CpuVector<ulong>(n256);
            var cin = Random.CpuVector<ulong>(n256);
            (var sum, var cout) = FullAdder.Compute(x,y, cin);

            var sumbs = sum.ToBitString();
            var coutbs = cout.ToBitString();
            var xbs = x.ToBitString();
            var ybs = y.ToBitString();
            var cinbs = cin.ToBitString();
            for(var i=0; i<xbs.Length; i++)
            {
                var expect = FullAdder.Compute(xbs[i],ybs[i],cinbs[i]);
                Claim.eq(expect.A, sumbs[i]);
                Claim.eq(expect.B, coutbs[i]);
            }
        }

        public void bvfulladder_32x32x64()
        {
            var x = Random.BitVector(n32);
            var y = Random.BitVector(n32);
            var cin = BitVector32.Zero;

            var v64 = FullAdder.Compute(x,y,cin);
            var sum = v64.Lo;
            var cout = v64.Hi;
            for(var i=0; i<sum.Width; i++)
            {
                var expect = FullAdder.Compute(x[i], y[i], cin[i]);
                Claim.eq(expect.A, sum[i]);
                Claim.eq(expect.B, cout[i]);
            }
        }
    }
}