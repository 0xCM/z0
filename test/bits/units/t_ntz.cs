//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class t_ntz : t_bitcore<t_ntz>
    {        
        public void ntz_outline()
        {
            Claim.Eq((byte)3, gbits.ntz((byte)0b111000));
            Claim.Eq(2u, gbits.ntz(0b0001011000100u));
            Claim.Eq(5u, gbits.ntz(0b000101100000u));
            Claim.Eq(3ul, gbits.ntz(Pow2.pow(3)));            
        }

        public void ntz_8()
            => ntz_check<byte>();

        public void ntz_16()
            => ntz_check<ushort>();

        public void ntz_32()
            => ntz_check<uint>();

        public void ntz_64()
            => ntz_check<ulong>();
 
        protected void ntz_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var ntzX = gbits.ntz(x);
                var y = BitString.scalar(x);
                var ntzY = As.generic<T>(y.Ntz());

                if(gmath.neq(ntzX, ntzY))
                {
                    Trace("scalar", x.ToString());
                    Trace("bitstring", y.Format());
                }

                Claim.Eq(ntzX, ntzY);
            }
        }
 
    }

}