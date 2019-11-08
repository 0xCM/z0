//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    using static LogicEngine;

    public class t_logic_composition : UnitTest<t_logic_composition>
    {

        public void test1()
        {
            
            var a = literal<uint>(true);
            var b = literal<uint>(false);
            var c = and(a,b);
            var result = eval(c);
            Claim.nea(result);

        }


        
    }

}