//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static ComparisonOpKind;

    using A = OpKindAttribute;

    public sealed class EqAttribute : A { public EqAttribute() : base(Eq) {} }

    public sealed class EqzAttribute : A { public EqzAttribute() : base(Eqz) {} }

    public sealed class NeqAttribute : A { public NeqAttribute() : base(Neq) {} }

    public sealed class LtAttribute : A { public LtAttribute() : base(Lt) {} }

    public sealed class LtzAttribute : A { public LtzAttribute() : base(Ltz) {} }

    public sealed class LtEqAttribute : A { public LtEqAttribute() : base(LtEq) {} }

    public sealed class GtAttribute : A { public GtAttribute() : base(Gt) {} }

    public sealed class GtzAttribute : A { public GtzAttribute() : base(Gtz) {} }

    public sealed class GtEqAttribute : A { public GtEqAttribute() : base(GtEq) {} }

    public sealed class BetweenAttribute : A { public BetweenAttribute() : base(Between) {} }

    public sealed class MaxAttribute : A { public MaxAttribute() : base(Max) {} }

    public sealed class MinAttribute : A { public MinAttribute() : base(Min) {} }
}