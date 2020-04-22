//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum ClaimKind
    {
        Eq,
        
        Close,
        
        EqItem,

        NEq,

        Lt,

        LtEq,
        
        Gt,
        
        GtEq,
        
        False,

        True,

        Fail,

        Nonzero,
        
        Between,

        NotIn,

        Invariant
    }    
}