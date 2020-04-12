//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Id = OpKindId;

    public enum UnaryComparisonKind : ulong
    {
        None = 0,

        Negative = Id.Negative,

        Positive = Id.Positive,

        Nonz = Id.Nonz,        
    }
}