//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using Id = OpKindId;

    public enum NumericAggregateKind : ulong
    {
        None = 0,

        Sum = Id.Sum,

        Avg = Id.Avg,

        Avgz = Id.Avgz,

        Avgi = Id.Avgz,

        AggMax = Id.AggMax,

        AggMin = Id.AggMin
    }
}