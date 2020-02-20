//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

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
            var n = bitsize<T>();
            var dst = gbits.bitclear(gmath.maxval<T>(), first, count);           
            var bs = BitString.scalar(dst);
            Claim.eq(bs.Length, n);
            for(var i=0; i<bs.Length; i++)
            {
                if(i >= first && i < first + count)
                    Claim.nea(bs[i]);
                else
                    Claim.yea(bs[i]);
            }
        }
        
    }
}