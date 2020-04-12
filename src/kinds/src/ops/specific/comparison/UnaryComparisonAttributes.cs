//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;
    using K = UnaryComparisonKind;

    public sealed class NegativeAttribute : A { public NegativeAttribute() : base(K.Negative) {} }

    public sealed class PositiveAttribute : A { public PositiveAttribute() : base(K.Positive) {} }

    public sealed class NonzAttribute : A { public NonzAttribute() : base(K.Nonz) {} }
}
