//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static UnaryComparisonKind;

    using A = OpKindAttribute;

    public sealed class NegativeAttribute : A { public NegativeAttribute() : base(Negative) {} }

    public sealed class PositiveAttribute : A { public PositiveAttribute() : base(Positive) {} }

    public sealed class DividesAttribute : A { public DividesAttribute() : base(Divides) {} }

    public sealed class NonzAttribute : A { public NonzAttribute() : base(Nonz) {} }
}
