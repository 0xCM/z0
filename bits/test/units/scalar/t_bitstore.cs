//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bitstore : ScalarBitTest<t_bitstore>
    {

        public void bitseq_lookup_check()
        {

            for(var i=0; i<255; i++)
            {
                var bs = ((byte)i).ToBitString();
                var lu1 = BitStore.select((byte)i);
                var lu2 = BitStore.select_alt((byte)i);
                Claim.eq(bs.Length, lu1.Length);
                Claim.eq(bs.Length, lu2.Length);
                for(var j=0; j<bs.Length; j++)
                {
                    Claim.eq(bs[j], (bit)lu1[j]);
                    Claim.eq(bs[j], (bit)lu2[j]);
                }
            }
        }



    }

}