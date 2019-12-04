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

    public class t_vpermlo : t_vinx<t_vpermlo>
    {
        const byte A = 0b00;
        
        const byte B = 0b01;

        const byte C = 0b10;

        const byte D = 0b11;


        public void vpermlo_4x16_basecase()
        {
            var x = ginx.vincrements<ushort>(n128);
            var xs = x.ToSpan();
            Claim.eq(Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]), x);

            var xABCD = dinx.vpermlo4x16(x, Perm4.ABCD);
            Claim.eq(xABCD, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xDCBA = dinx.vpermlo4x16(x, Perm4.DCBA);
            Claim.eq(xDCBA, Vector128.Create(xs[D], xs[C], xs[B], xs[A], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xACBD = dinx.vpermlo4x16(x, Perm4.ACBD);
            Claim.eq(xACBD, Vector128.Create(xs[A], xs[C], xs[B], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            Claim.eq(dinx.vpermlo4x16(dinx.vparts(n128, 0,1,2,3,6,7,8,9), Perm4.ADCB), dinx.vparts(n128, 0,3,2,1,6,7,8,9));           
        }

    }

}