//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct IntelAlgorithms
    {
        public readonly struct Operator
        {
            public string Symbol {get;}

            public OperatorKind Kind {get;}

            [MethodImpl(Inline)]
            public Operator(string symbol, OperatorKind kind)
            {
                Symbol = symbol;
                Kind = kind;
            }
        }
    }
}