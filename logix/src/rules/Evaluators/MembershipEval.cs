//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;


    readonly struct MembershipEval<T>
        where T : unmanaged
    {
        public static readonly DateCmpEval TheOnly = default;

        public bool Satisfies(MembershipExpr<T> rule, LiteralRuleExpr<T> test)
            => (rule.Test == MembershipTest.IsMember && rule.Value.Contains(test.Value))
            || (rule.Test == MembershipTest.IsNotMember && !rule.Value.Contains(test.Value));
    }


}