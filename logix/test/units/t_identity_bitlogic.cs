
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    using static LogicEngine;
    using static BitLogicSpec;
    using static TypedLogicSpec;
    using static LogicIdentities;
    


    public class t_identity_bitlogic : UnitTest<t_identity_bitlogic>
    {
        public void check_not_over_and()
            => check_exhaustive(NotOverAnd);

        public void check_not_over_xor()
            => check_exhaustive(NotOverXOr);

        public void check_and_over_or()
            => check_exhaustive(AndOverOr);

        public void check_and_over_xor()
            => check_exhaustive(AndOverXOr);

        public void check_or_over_and()
            => check_exhaustive(OrOverAnd);

        void check_exhaustive(EqualityExpr t)
        {
            //Trace(t.Format());
            foreach(var c in bitcombo(t.Vars.Length))
            {
                t.SetVars(c);
                Claim.eq(bit.On,LogicEngine.eval(t));
                LogicEngine.satisfied(t, c[0], c[1]);                
            }
        }



    }

}