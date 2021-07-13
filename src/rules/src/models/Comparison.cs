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
        public readonly struct Comparison
        {
            public OperandSpec Left {get;}

            public OperandSpec Right {get;}

            public ComparisonKind Kind {get;}

            [MethodImpl(Inline)]
            public Comparison(OperandSpec left, OperandSpec right, ComparisonKind kind)
            {
                Left = left;
                Right = right;
                Kind = kind;
            }
        }
    }
}