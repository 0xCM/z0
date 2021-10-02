//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        public readonly struct Implication : IRule<Implication>
        {
            public dynamic Antecedant {get;}

            public dynamic Consequent {get;}

            [MethodImpl(Inline)]
            public Implication(dynamic a, dynamic c)
            {
                Antecedant = a;
                Consequent = c;
            }
        }
    }
}