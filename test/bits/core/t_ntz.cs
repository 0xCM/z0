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
            Claim.eq(3, gbits.ntz((byte)0b111000));
            Claim.eq(2, gbits.ntz(0b0001011000100u));
            Claim.eq(5, gbits.ntz(0b000101100000u));
            Claim.eq(3, gbits.ntz(Pow2.pow(3)));            
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
                var ntzY = y.Ntz();

                if(ntzX != ntzY)
                {
                    trace("scalar", x.ToString());
                    trace("bitstring", y.Format());
                }

                Claim.eq(ntzX, ntzY);
            }
        }
 
    }

}