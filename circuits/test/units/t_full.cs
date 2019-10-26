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
    
    using static zfunc;

    public class t_full : UnitTest<t_full>
    {

        public void fa_1b()
        {
            FullAdder.Compute(Bit.Off, Bit.Off, Bit.Off, out Bit s0, out Bit c0);
            Claim.eq(s0, Bit.Off);
            Claim.eq(c0, Bit.Off);

            FullAdder.Compute(Bit.On, Bit.Off, Bit.Off, out Bit s1, out Bit c1);
            Claim.eq(s1, Bit.On);
            Claim.eq(c1, Bit.Off);

            FullAdder.Compute(Bit.On, Bit.On, Bit.Off, out Bit s2, out Bit c2);
            Claim.eq(s2, Bit.Off);
            Claim.eq(c2, Bit.On);

            FullAdder.Compute(Bit.On, Bit.On, Bit.On, out Bit s3, out Bit c3);
            Claim.eq(s3, Bit.On);
            Claim.eq(c3, Bit.On);

            FullAdder.Compute(Bit.Off, Bit.Off, Bit.On, out Bit s4, out Bit c4);
            Claim.eq(s4, Bit.On);
            Claim.eq(c4, Bit.Off);

        }

        public void fa_1b_paired()
        {
            (var s0, var c0) = FullAdder.Compute(Bit.Off, Bit.Off, Bit.Off);
            Claim.eq(s0, Bit.Off);
            Claim.eq(c0, Bit.Off);

            (var s1, var c1) = FullAdder.Compute(Bit.On, Bit.Off, Bit.Off);
            Claim.eq(s1, Bit.On);
            Claim.eq(c1, Bit.Off);

            (var s2, var c2) = FullAdder.Compute(Bit.On, Bit.On, Bit.Off);
            Claim.eq(s2, Bit.Off);
            Claim.eq(c2, Bit.On);

            (var s3, var c3) = FullAdder.Compute(Bit.On, Bit.On, Bit.On);
            Claim.eq(s3, Bit.On);
            Claim.eq(c3, Bit.On);

            (var s4, var c4) = FullAdder.Compute(Bit.Off, Bit.Off, Bit.On);
            Claim.eq(s4, Bit.On);
            Claim.eq(c4, Bit.Off);

            (var s5, var c5) = FullAdder.Compute(Bit.Off, Bit.On, Bit.On);
            Claim.eq(s5, Bit.Off);
            Claim.eq(c5, Bit.On);

        }

        public void fa_256x64u_check()
        {
            var x = Random.CpuVector256<ulong>();
            var y = Random.CpuVector256<ulong>();
            var cin = Random.CpuVector256<ulong>();
            (var sum, var cout) = FullAdder.Compute(x,y, cin);
            
            var sumbs = sum.ToBitString();
            var coutbs = cout.ToBitString();
            var xbs = x.ToBitString();
            var ybs = y.ToBitString();
            var cinbs = cin.ToBitString();
            for(var i=0; i<xbs.Length; i++)
            {
                var expect = FullAdder.Compute(xbs[i],ybs[i],cinbs[i]);
                Claim.eq(expect.x, sumbs[i]);
                Claim.eq(expect.y, coutbs[i]);
            }
        }

        public void fa_32x32x64_bv()
        {
            var x = Random.BitVector(n32);
            var y = Random.BitVector(n32);
            var cin = BitVector32.Zero;

            var v64 = FullAdder.Compute(x,y,cin);
            var sum = v64.Lo;
            var cout = v64.Hi;
            for(var i=0; i<sum.Length; i++)
            {
                var expect = FullAdder.Compute(x[i], y[i], cin[i]);
                Claim.eq(expect.x, sum[i]);
                Claim.eq(expect.y, cout[i]);
            }
        }

    }

}