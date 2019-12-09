//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_clear : t_sb<t_sb_clear>
    {            
        public void sb_clear_basecases()
        {
            sb_clear_check<byte>(1,3);
            sb_clear_check<ushort>(7,4);            
            sb_clear_check<uint>(15,5);
            sb_clear_check<ulong>(21,11);
        }
        
        protected void sb_clear_check<T>(int first, int count)        
            where T : unmanaged
        {
            var n = bitsize<T>();
            var dst = gbits.clear(gmath.maxval<T>(), first, count);           
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