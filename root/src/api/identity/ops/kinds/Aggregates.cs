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
    
    using Id = OpKindId;
    using A = OpKindAttribute;

    public enum NumericAggregateKind : ulong
    {
        None = 0,

        Sum = Id.Sum,

        Avg = Id.Avg,

        Avgz = Id.Avgz,

    }

    public sealed class SumAttribute : A { public SumAttribute() : base(Sum) {} }

    public sealed class AvgAttribute : A { public AvgAttribute() : base(Avg) {} }

    public sealed class AvgzAttribute : A { public AvgzAttribute() : base(Avgz) {} }
}