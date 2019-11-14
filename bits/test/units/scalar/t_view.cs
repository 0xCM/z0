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
        
    public class t_bitview : ScalarBitTest<t_bitview>
    {

        public void VerifyPrimalView()
        {
            var src = UInt64.MaxValue;  
            var len = sizeof(ulong);
            var view = BitView.Over(ref src);
            for(var i=0; i<len; i++)
            for(byte j=0; j<8; j++)
                view[i,j] = j % 2 == 0;
            
            var bs = src.ToBitString();
            for(var i=0; i< len*8; i++)
                Claim.yea(bs[i] == (i%2 == 0));

        }

    }

}