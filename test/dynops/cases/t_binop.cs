//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Kinds;
    using static DisassemblyInvocation;

    public class t_binop : t_dynamic<t_binop>
    {
        public void binop_8()
        {
            var result = eval(default(Mul), 3,9);
            Claim.eq((byte)27,result);
        }        
    }
}