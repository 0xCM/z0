//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using Rules;

    public readonly struct EbnfRules
    {
        public sealed class DecimalDigit : EnbfRule<Union<AsciCharSym>>
        {
            public DecimalDigit(EbnfInstance g)
                : base(g)
            {
                //Term = lang.union(lang.atom((uint)AsciCharSym.d0, AsciCharSym.d0), AsciCharSym.d1, AsciCharSym.d2, AsciCharSym.d3, AsciCharSym.d4, AsciCharSym.d5, AsciCharSym.d6, AsciCharSym.d7,AsciCharSym.d8, AsciCharSym.d9);
            }

            public override Union<AsciCharSym> Term {get;}
        }
    }
}