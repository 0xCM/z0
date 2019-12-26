//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_lsbx : t_bitcore<t_lsbx>
    {
        public void xlsb_outline()
        {
            //lsbx is an identity function over a domain consisting of powers of 2
            for(byte i = 0; i< 64; i++)
                Claim.eq(Pow2.pow(i), gbits.lsbx(Pow2.pow(i)));
        }

        public void sb_lsbx_8()
            => sb_lsbx_check<byte>();

        public void sb_lsbx_16()
            => sb_lsbx_check<ushort>();

        public void sb_lsbx_32()
            => sb_lsbx_check<uint>();

        public void sb_lsbx_64()
            => sb_lsbx_check<ulong>();
 

        protected void sb_lsbx_check<T>(T t = default)
            where T : unmanaged
        {

            for(var i=0; i<SampleCount; i++)
            {
                var src = Random.Next<T>();
                var x = gbits.lsbx(src);
                var y = gmath.and(src, gmath.negate(src));
                Claim.eq(x,y);
            }
        }
 
    }
}