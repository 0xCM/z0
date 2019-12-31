//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
 
    public class t_cnonimpl : t_bitcore<t_cnonimpl>
    {
        public void cnonimpl_8u()
            => cnonimpl_check<byte>();

        public void cnonimpl_16u()
            => cnonimpl_check<ushort>();

        public void cnonimpl_32u()
            => cnonimpl_check<uint>();

        public void cnonimpl_64u()
            => cnonimpl_check<ulong>();

        protected void cnonimpl_check<T>(T t = default)
            where T : unmanaged
        {
            var vZero = vzero<T>(n128);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<T>();                    
                var y = Random.Next<T>();                    
                var z1 = gmath.cnonimpl(x, y);
                var z2 = gmath.and(x,gmath.not(y));
                Claim.eq(z1,z2);
            }
        }

    }
}