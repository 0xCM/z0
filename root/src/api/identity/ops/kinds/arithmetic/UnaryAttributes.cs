//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static UnaryArithmeticKind;
    
    using A = OpKindAttribute;

    public sealed class IncAttribute : A { public IncAttribute() : base(Inc) {} }

    public sealed class DecAttribute : A { public DecAttribute() : base(Dec) {} }

    public sealed class NegateAttribute : A { public NegateAttribute() : base(Negate) {} }

    public sealed class AbsAttribute : A { public AbsAttribute() : base(Abs) {} }

    public sealed class SquareAttribute : A { public SquareAttribute() : base(Square) {} }

    public sealed class SqrtAttribute : A { public SqrtAttribute() : base(Sqrt) {} }

}