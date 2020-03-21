//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Id = OpKindId;
    using A = OpKindAttribute;

    using static TernaryComparisonKind;

    /// <summary>
    /// Identifies binary comparison predicates
    /// </summary>
    public enum TernaryComparisonKind : ulong
    {        
        None = 0,

        Between = Id.Between,

        Within = Id.Within,
    }

    public sealed class BetweenAttribute : A { public BetweenAttribute() : base(Between) {} }

    public sealed class WithinAttribute : A { public WithinAttribute() : base(Within) {} }
}