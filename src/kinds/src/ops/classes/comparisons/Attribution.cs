//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;
    using K = ComparisonKind;

    public sealed class EqAttribute : A { public EqAttribute(object group = null) : base(K.Eq, group) {} }

    public sealed class EqzAttribute : A { public EqzAttribute(object group = null) : base(K.Eqz, group) {} }

    public sealed class NeqAttribute : A { public NeqAttribute(object group = null) : base(K.Neq, group) {} }

    public sealed class LtAttribute : A { public LtAttribute(object group = null) : base(K.Lt, group) {} }

    public sealed class LtzAttribute : A { public LtzAttribute(object group = null) : base(K.Ltz, group) {} }

    public sealed class LtEqAttribute : A { public LtEqAttribute(object group = null) : base(K.LtEq, group) {} }

    public sealed class GtAttribute : A { public GtAttribute(object group = null) : base(K.Gt, group) {} }

    public sealed class GtzAttribute : A { public GtzAttribute(object group = null) : base(K.Gtz, group) {} }

    public sealed class GtEqAttribute : A { public GtEqAttribute(object group = null) : base(K.GtEq, group) {} }

    public sealed class DividesAttribute : A { public DividesAttribute(object group = null) : base(K.Divides, group) {} }

    public sealed class BetweenAttribute : A { public BetweenAttribute(object group = null) : base(K.Between, group) {} }

    public sealed class WithinAttribute : A { public WithinAttribute(object group = null) : base(K.Within, group) {} }

    public sealed class NegativeAttribute : A { public NegativeAttribute(object group = null) : base(K.Negative, group) {} }

    public sealed class PositiveAttribute : A { public PositiveAttribute(object group = null) : base(K.Positive, group) {} }

    public sealed class NonzAttribute : A { public NonzAttribute(object group = null) : base(K.Nonz, group) {} }        
}