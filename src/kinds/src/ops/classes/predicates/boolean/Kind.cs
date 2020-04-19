//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Id = OpKindId;

    public enum BooleanPredicateKind : ulong
    {
        None = 0,

        Even = Id.Even,

        Odd = Id.Odd,
    }

}