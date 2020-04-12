//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;    
    using K = FunctionKind;

    public sealed class IdentityFunctionAttribute : A { public IdentityFunctionAttribute() : base(K.Identity) {} }

    public sealed class ConcatAttribute : A { public ConcatAttribute() : base(K.Concat) {} }

    public sealed class BroadcastAttribute : A { public BroadcastAttribute() : base(K.Broadcast) {} }


    public sealed class ReverseAttribute : A { public ReverseAttribute() : base(K.Reverse) {} }    
}