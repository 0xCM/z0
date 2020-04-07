//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using A = OpKindAttribute;
    using K = NumericAggregateKind;

    public sealed class SumAttribute : A { public SumAttribute() : base(K.Sum) {} }

    public sealed class AvgAttribute : A { public AvgAttribute() : base(K.Avg) {} }

    public sealed class AvgzAttribute : A { public AvgzAttribute() : base(K.Avgz) {} }

    public sealed class AvgiAttribute : A { public AvgiAttribute() : base(K.Avgi) {} }

    public sealed class AggMaxAttribute : A { public AggMaxAttribute() : base(K.AggMax) {} }

    public sealed class AggMinAttribute : A { public AggMinAttribute() : base(K.AggMin) {} }
}