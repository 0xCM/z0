//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Constant
        {
            public dynamic Value {get;}

            public ConstantKind Kind {get;}

            [MethodImpl(Inline)]
            public Constant(dynamic value, ConstantKind kind)
            {
                Value = value;
                Kind = kind;
            }
        }
    }
}