
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
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    using static BitLogicSpec;

    public class t_logic_identities : UnitTest<t_logic_identities>
    {
        public void check_identities()
        {
            iter(LogicIdentities.All, check_exhaustive);
        }
        
        void check_exhaustive(EqualityExpr t)
        {
            foreach(var c in bitcombo(t.Vars.Length))
            {
                t.SetVars(c);
                Claim.eq(bit.On,LogicEngine.eval(t));
                Claim.yea(LogicEngine.satisfied(t, c[0], c[1]));
            }
        }
    }
}