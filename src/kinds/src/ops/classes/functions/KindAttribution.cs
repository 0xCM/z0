//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;    
    using K = FunctionKind;

    public sealed class IdentityFunctionAttribute : A { public IdentityFunctionAttribute(string group = null) : base(K.Identity, group) {} }

    public sealed class ConcatAttribute : A { public ConcatAttribute(string group = null) : base(K.Concat, group) {} }

    public sealed class BroadcastAttribute : A { public BroadcastAttribute(string group = null) : base(K.Broadcast, group) {} }

    public sealed class ReverseAttribute : A { public ReverseAttribute(string group = null) : base(K.Reverse, group) {} }    
}