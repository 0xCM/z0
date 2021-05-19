//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    partial struct Expr
    {
        public readonly struct UnaryArithmetic
        {
            public UnaryArithmeticKind Kind {get;}
        }


        public readonly struct BooleanComparison
        {
            public ComparisonKind Kind {get;}
        }
    }
}