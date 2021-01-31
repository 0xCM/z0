//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public class t_bitclear : t_bitcore<t_bitclear>
    {
        public void clearbits_outline()
        {
            clearbits_check<byte>(1,3);
            clearbits_check<ushort>(7,4);
            clearbits_check<uint>(15,5);
            clearbits_check<ulong>(21,11);
        }

        void clearbits_check<T>(byte first, byte count)
            where T : unmanaged
        {
            var n = bitwidth<T>();
            var dst = gbits.disable(Numeric.maxval<T>(), first, count);
            var bs = BitSpans.create(dst);
            var len = bs.Length;
            Claim.eq(len, n);
            for(var i=0; i<len; i++)
            {
                if(i >= first && i < first + count)
                    Claim.nea(bs[i]);
                else
                    Claim.Require(bs[i]);
            }
        }
    }
}