//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Id = OpKindId;


    public enum FunctionKind : ulong
    {
        None = 0,

        Concat = Id.Concat,

        Broadcast = Id.Broadcast,

        Reverse = Id.Reverse,

        Identity = Id.Identity,
    }
}