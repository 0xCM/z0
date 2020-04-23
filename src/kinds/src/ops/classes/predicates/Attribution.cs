//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;
    using K = BooleanPredicateKind;

    public sealed class EvenAttribute : A { public EvenAttribute(string group = null) : base(K.Even, group) {} }

    public sealed class OddAttribute : A { public OddAttribute(string group = null) : base(K.Odd, group) {} }

    public sealed class EqPredAttribute : A { public EqPredAttribute(string group = null) : base(K.EqPred, group) {} }

    public sealed class NeqPredAttribute : A { public NeqPredAttribute(string group = null) : base(K.NeqPred, group) {} }

    public sealed class GtPredAttribute : A { public GtPredAttribute(string group = null) : base(K.GtPred, group) {} }
    
    public sealed class GtEqPredAttribute : A { public GtEqPredAttribute(string group = null) : base(K.GtEqPred, group) {} }

    public sealed class LtPredAttribute : A { public LtPredAttribute(string group = null) : base(K.LtPred, group) {} }
    
    public sealed class LtEqPredAttribute : A { public LtEqPredAttribute(string group = null) : base(K.LtEqPred, group) {} }
}