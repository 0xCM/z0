//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class t_bitstring_convert : t_bitspans<t_bitstring_convert>
    {
        public void bitspan_from_bitstring_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var bs = Random.BitString(5,233);
                var bc = BitBlocks.from<T>(bs);
                Claim.eq(bs.Length, bc.BitCount);
                for(var j=0; j<bs.Length; j++)
                {
                    if(bc[j] != bs[j])
                    {
                        Trace("bs", bs.Format());
                        Trace("bc", bc.Format());
                    }
                    Claim.eq(bc[j],bs[j]);
                }
            }
        }

        public void bsp_16u_from_bs()
            => bitspan_from_bitstring_check<ushort>();

        public void bsp_32u_from_bs()
            => bitspan_from_bitstring_check<uint>();

        public void bsp_64u_from_bs()
            => bitspan_from_bitstring_check<ulong>();
    }
}