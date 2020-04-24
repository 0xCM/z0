//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = CanonicalKind;
    using A = OpKindAttribute;    

    public sealed class IdentityFunctionAttribute : A { public IdentityFunctionAttribute(object group = null) : base(K.Identity, group) {} }

    public sealed class ConcatAttribute : A { public ConcatAttribute(object group = null) : base(K.Concat, group) {} }

    public sealed class ReverseAttribute : A { public ReverseAttribute(object group = null) : base(K.Reverse, group) {} }    

    public sealed class ParseAttribute : A { public ParseAttribute(object group = null) : base(K.Parse, group) {} }    
}