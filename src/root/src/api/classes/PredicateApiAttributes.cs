//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using A = OpKindAttribute;
    using K = PredicateApiClass;

    public sealed class EvenAttribute : A { public EvenAttribute() : base(K.Even) {} }

    public sealed class OddAttribute : A { public OddAttribute() : base(K.Odd) {} }

    public sealed class EqPredAttribute : A { public EqPredAttribute() : base(K.EqPred) {} }

    public sealed class NeqPredAttribute : A { public NeqPredAttribute() : base(K.NeqPred) {} }

    public sealed class GtPredAttribute : A { public GtPredAttribute() : base(K.GtPred) {} }

    public sealed class GtEqPredAttribute : A { public GtEqPredAttribute() : base(K.GtEqPred) {} }

    public sealed class LtPredAttribute : A { public LtPredAttribute() : base(K.LtPred) {} }

    public sealed class LtEqPredAttribute : A { public LtEqPredAttribute() : base(K.LtEqPred) {} }
}