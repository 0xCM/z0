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
    using static Classifiers;

    public sealed class t_moniker : UnitTest<t_moniker>
    {

        public void evolve()
        {
            var name = "xor";
            var kind = u8;
            var m0 = Moniker.define(name,kind);
            Claim.eq("xor_8u", m0.Text);
            Claim.eq(name, m0.Name);
            Claim.eq(8,m0.PrimalWidth);
            Claim.nea(m0.IsSegmented);
            Claim.nea(m0.IsGeneric);
            Claim.nea(m0.IsAsm);
            Claim.eq(kind, m0.PrimalKind);

            var m1 = m0.WithGeneric();
            Claim.eq("xor_g8u", m1.Text);
            Claim.eq(name,m1.Name);
            Claim.yea(m1.IsGeneric);
            Claim.eq(kind, m1.PrimalKind);

            var m2 = m0.WithAsm();
            Claim.eq("xor_8u-asm", m2.Text);
            Claim.eq(name, m2.Name);
            Claim.eq(8,m2.PrimalWidth);
            Claim.yea(m2.IsAsm);
            Claim.yea(m2.HasSuffix);
            Claim.eq("asm", m2.Suffix);
            Claim.eq(kind, m2.PrimalKind);

        }

    }

}