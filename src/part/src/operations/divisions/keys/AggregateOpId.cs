//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Id = ApiKeyKind;

    public enum AggregateOpId : ulong
    {
        None = 0,

        Sum = Id.Sum,

        Avg = Id.Avg,

        AggMax = Id.AggMax,

        AggMin = Id.AggMin
    }
}