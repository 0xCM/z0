//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;
    using K = BooleanPredicateKind;

    public sealed class EvenAttribute : A { public EvenAttribute(string group = null) : base(K.Even, group) {} }

    public sealed class OddAttribute : A { public OddAttribute(string group = null) : base(K.Odd, group) {} }

}