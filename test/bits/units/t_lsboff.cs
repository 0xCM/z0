//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public class t_lsboff : t_bitcore<t_lsboff>
    {
        public void lsboff_8()
            => lsboff_check<byte>();

        public void lsboff_16()
            => lsboff_check<ushort>();

        public void lsboff_32()
            => lsboff_check<uint>();

        public void lsboff_64()
            => lsboff_check<ulong>();

        protected void lsboff_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<T>();
                var y0 = gbits.blsr(x);
                var y1 = gmath.and(gmath.sub(x, AsDeprecated.one<T>()), x);
                Claim.Eq(y0,y1);
            }
        }

    }
}
