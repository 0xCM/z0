//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;    
    using K = BinaryFunctionKind;

    public sealed class ConcatAttribute : A { public ConcatAttribute() : base(K.Concat) {} }

    public sealed class BroadcastAttribute : A { public BroadcastAttribute() : base(K.Broadcast) {} }
}