//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_typesigs : t_fastop<t_typesigs>
    {        
        public void sig_natspan()
        {
            foreach(var c in NatSpanCases.All)
            {
                var expect = NatSpanType.signature(c.type).Require();
                var actual = NatSpanType.signature(c.id).Require();
                Claim.eq(expect,actual);                
            }
        }
    }
}