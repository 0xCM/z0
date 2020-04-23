//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;
    using K = ComparisonKind;

    public sealed class EqAttribute : A { public EqAttribute(string group = null) : base(K.Eq, group) {} }

    public sealed class EqzAttribute : A { public EqzAttribute(string group = null) : base(K.Eqz, group) {} }

    public sealed class NeqAttribute : A { public NeqAttribute(string group = null) : base(K.Neq, group) {} }

    public sealed class LtAttribute : A { public LtAttribute(string group = null) : base(K.Lt, group) {} }

    public sealed class LtzAttribute : A { public LtzAttribute(string group = null) : base(K.Ltz, group) {} }

    public sealed class LtEqAttribute : A { public LtEqAttribute(string group = null) : base(K.LtEq, group) {} }

    public sealed class GtAttribute : A { public GtAttribute(string group = null) : base(K.Gt, group) {} }

    public sealed class GtzAttribute : A { public GtzAttribute(string group = null) : base(K.Gtz, group) {} }

    public sealed class GtEqAttribute : A { public GtEqAttribute(string group = null) : base(K.GtEq, group) {} }

    public sealed class DividesAttribute : A { public DividesAttribute(string group = null) : base(K.Divides, group) {} }

    public sealed class BetweenAttribute : A { public BetweenAttribute(string group = null) : base(K.Between, group) {} }

    public sealed class WithinAttribute : A { public WithinAttribute(string group = null) : base(K.Within, group) {} }

    public sealed class NegativeAttribute : A { public NegativeAttribute(string group = null) : base(K.Negative, group) {} }

    public sealed class PositiveAttribute : A { public PositiveAttribute(string group = null) : base(K.Positive, group) {} }

    public sealed class NonzAttribute : A { public NonzAttribute(string group = null) : base(K.Nonz, group) {} }        
}