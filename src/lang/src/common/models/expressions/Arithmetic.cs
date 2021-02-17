//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Expr
    {
        public readonly struct UnaryArithmetic
        {

        }

        public readonly struct BinaryArithmetic
        {

        }

        public readonly struct BooleanComparison
        {
            public ComparisonKind Kind {get;}
        }
    }
}