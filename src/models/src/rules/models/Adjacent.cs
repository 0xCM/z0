//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Rules;

    partial struct Rules
    {
        public readonly struct Adjacent : ITerm
        {
            public dynamic A {get;}

            public dynamic B {get;}

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