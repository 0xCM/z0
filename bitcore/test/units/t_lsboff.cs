//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_lsboff : t_bitcore<t_lsboff>
    {
        public void sb_lsboff_8()
            => sb_lsboff_check<byte>();

        public void sb_lsboff_16()
            => sb_lsboff_check<ushort>();

        public void sb_lsboff_32()
            => sb_lsboff_check<uint>();

        public void sb_lsboff_64()
            => sb_lsboff_check<ulong>();

        protected void sb_lsboff_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<T>();
                var y0 = gbits.lsboff(x);
                var y1 = gmath.and(gmath.sub(x, gmath.one<T>()), x);
                Claim.eq(y0,y1);
            }
        }

    }
}
