//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static BitLogicSpec;



    public class t_probes : UnitTest<t_probes>
    {
        public void probe_select()
        {
            var a = BitVector.create(n8,0b10101010);
            var b = BitVector.create(n8,0b10101010);
            var c = BitVector.create(n8,0b01010101);
            var d = BitVector.create(n8,0b11111111);
            var z = BitVector.select(a,b,c);
            Claim.eq(z,d);
        }

    }

}