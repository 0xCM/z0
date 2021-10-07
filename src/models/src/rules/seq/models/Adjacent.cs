//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using api = SeqRules;

    partial struct SeqRules
    {
        public readonly struct Adjacent : ITerm
        {
            public readonly dynamic A;

            public readonly dynamic B;

            [MethodImpl(Inline)]
            public Adjacent(dynamic a, dynamic b)
            {
                A = a;
                B = b;
            }

            public string Format()
                => api.format(this);


            public override string ToString()
                => Format();
        }
    }
}