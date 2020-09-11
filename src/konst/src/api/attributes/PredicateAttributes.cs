//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using A = OpKindAttribute;
    using K = BooleanPredicateOpId;

    public sealed class EvenAttribute : A { public EvenAttribute(object group = null) : base(K.Even, group) {} }

    public sealed class OddAttribute : A { public OddAttribute(object group = null) : base(K.Odd, group) {} }

    public sealed class EqPredAttribute : A { public EqPredAttribute(object group = null) : base(K.EqPred, group) {} }

    public sealed class NeqPredAttribute : A { public NeqPredAttribute(object group = null) : base(K.NeqPred, group) {} }

    public sealed class GtPredAttribute : A { public GtPredAttribute(object group = null) : base(K.GtPred, group) {} }

    public sealed class GtEqPredAttribute : A { public GtEqPredAttribute(object group = null) : base(K.GtEqPred, group) {} }

    public sealed class LtPredAttribute : A { public LtPredAttribute(object group = null) : base(K.LtPred, group) {} }

    public sealed class LtEqPredAttribute : A { public LtEqPredAttribute(object group = null) : base(K.LtEqPred, group) {} }
}