//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static NumericAggregateKind;
    
    using A = OpKindAttribute;

    public sealed class SumAttribute : A { public SumAttribute() : base(Sum) {} }

    public sealed class AvgAttribute : A { public AvgAttribute() : base(Avg) {} }

    public sealed class AvgzAttribute : A { public AvgzAttribute() : base(Avgz) {} }

    public sealed class AggMaxAttribute : A { public AggMaxAttribute() : base(AggMax) {} }

    public sealed class AggMinAttribute : A { public AggMinAttribute() : base(AggMin) {} }

}