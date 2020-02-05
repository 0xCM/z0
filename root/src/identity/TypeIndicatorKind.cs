//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static RootShare;

    public enum TypeIndicatorKind
    {
        None = 0,

        Vector,

        Block,

        Span,

        BitGrid,

        BitMatrix
    
    }

}