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

    public sealed class IdentityFunctionAttribute : A { public IdentityFunctionAttribute(string group = null) : base(K.Identity, group) {} }

    public sealed class ConcatAttribute : A { public ConcatAttribute(string group = null) : base(K.Concat, group) {} }

    public sealed class ReverseAttribute : A { public ReverseAttribute(string group = null) : base(K.Reverse, group) {} }    

    public sealed class ParseAttribute : A { public ParseAttribute(string group = null) : base(K.Parse, group) {} }    
}