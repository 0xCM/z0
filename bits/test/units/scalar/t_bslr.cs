//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class t_blsr : t_sb<t_blsr>
    {

        public void blsr_u8_check()
        {
            blsr_check<byte>();
        }

        public void blsr_u16_check()
        {
            blsr_check<ushort>();
        }

        public void blsr_u32_check()
        {
            blsr_check<uint>();
        }

        public void blsr_u64_check()
        {
            blsr_check<ulong>();
        }

        void blsr_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                var y0 = gbits.blsr(x);
                var y1 = gmath.and(gmath.sub(x, gmath.one<T>()), x);
                Claim.eq(y0,y1);
            }
        }

    }

}
