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
        public readonly struct Adjacent : IRule<Adjacent>
        {
            public dynamic A {get;}

            public dynamic B {get;}

            [MethodImpl(Inline)]
            public Adjacent(dynamic a, dynamic b)
            {
                A = a;
                B = b;
            }
        }
    }
}