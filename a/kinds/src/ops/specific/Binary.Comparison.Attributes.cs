//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;
    using K = BinaryComparisonKind;

    public sealed class EqAttribute : A { public EqAttribute() : base(K.Eq) {} }

    public sealed class EqzAttribute : A { public EqzAttribute() : base(K.Eqz) {} }

    public sealed class NeqAttribute : A { public NeqAttribute() : base(K.Neq) {} }

    public sealed class LtAttribute : A { public LtAttribute() : base(K.Lt) {} }

    public sealed class LtzAttribute : A { public LtzAttribute() : base(K.Ltz) {} }

    public sealed class LtEqAttribute : A { public LtEqAttribute() : base(K.LtEq) {} }

    public sealed class GtAttribute : A { public GtAttribute() : base(K.Gt) {} }

    public sealed class GtzAttribute : A { public GtzAttribute() : base(K.Gtz) {} }

    public sealed class GtEqAttribute : A { public GtEqAttribute() : base(K.GtEq) {} }

    public sealed class MaxAttribute : A { public MaxAttribute() : base(K.Max) {} }

    public sealed class MinAttribute : A { public MinAttribute() : base(K.Min) {} }
}