//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;
    using K = TernaryComparisonKind;

    public sealed class BetweenAttribute : A { public BetweenAttribute() : base(K.Between) {} }

    public sealed class WithinAttribute : A { public WithinAttribute() : base(K.Within) {} }
}