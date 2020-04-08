//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using A = OpKindAttribute;
    using K = UnaryArithmeticKind;

    public sealed class IncAttribute : A { public IncAttribute() : base(K.Inc) {} }

    public sealed class DecAttribute : A { public DecAttribute() : base(K.Dec) {} }

    public sealed class NegateAttribute : A { public NegateAttribute() : base(K.Negate) {} }

    public sealed class AbsAttribute : A { public AbsAttribute() : base(K.Abs) {} }

    public sealed class SquareAttribute : A { public SquareAttribute() : base(K.Square) {} }

    public sealed class SqrtAttribute : A { public SqrtAttribute() : base(K.Sqrt) {} }
}