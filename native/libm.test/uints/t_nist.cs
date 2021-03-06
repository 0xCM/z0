//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public class t_nist : t_libm<t_nist>
    {
        void add_check()
        {
            var x = 20451;
            var y = 1339283;
            var z = (x + y);

            Span<byte> a = new byte[8];
            x.ToBytes().AsSpan().CopyTo(a);
            
            Span<byte> b = new byte[8];
            y.ToBytes().AsSpan().CopyTo(b);

            NIST.add(a,b);

            var c = BitConverter.ToInt64(a);
            Claim.eq(z, c);

        }
    }

}