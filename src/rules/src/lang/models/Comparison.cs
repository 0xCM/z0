//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Comparison : IPredicate<Comparison>
    {
        public Operand Left {get;}

        public Operand Right {get;}

        public ComparisonKind Kind {get;}

        [MethodImpl(Inline)]
        public Comparison(Operand left, Operand right, ComparisonKind kind)
        {
            Left = left;
            Right = right;
            Kind = kind;
        }
    }
}