//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Id = OpKindId;

    public enum BinaryFunctionKind : ulong
    {
        None = 0,

        Concat = Id.Concat,

        Broadcast = Id.Broadcast,

    }

}