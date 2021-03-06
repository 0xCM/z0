//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct IntrinsicOperator
        {
            public string Name {get;}

            public string Notation {get;}

            public OperatorKind Kind {get;}

            [MethodImpl(Inline)]
            public IntrinsicOperator(string name, string notation, OperatorKind kind)
            {
                Name = name;
                Notation  = notation;
                Kind = kind;
            }
        }
    }
}