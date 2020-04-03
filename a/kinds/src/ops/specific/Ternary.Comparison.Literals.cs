//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Id = OpKindId;

    /// <summary>
    /// Identifies binary comparison predicates
    /// </summary>
    public enum TernaryComparisonKind : ulong
    {        
        None = 0,

        Between = Id.Between,

        Within = Id.Within,
    }
}