//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Konst;

    public class t_stringref : t_symbolic<t_stringref>
    {        
        const string S0 = "ABCDEFG";

        const string S1 ="HIJKLMN";

        public void tc_literal()
        {
            var r0 = z.@ref(S0);
            Claim.eq(r0.Text, S0);

            var r1 = z.@ref(S1);
            Claim.eq(r1.Text, S1);
        }

        public void tc_dynamic()
        {
            var dst = EmptyString;
            for(var i=0; i<9; i++)
            {
                dst += i.ToString()[0];
            }
            var r = z.@ref(dst);
            Claim.eq(dst, r.Text);
        }
    }
}