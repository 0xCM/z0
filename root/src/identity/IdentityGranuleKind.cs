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

    public enum IdentityGraunuleKind 
    {
        None,
        
        Name,

        ArgPart,

        ArgModifier,

        PartSeparator,

        SegSeparator,

        TypeWidth,

        SegWidth,

        TypeIndicator,

        NumericIndicator,

        Suffix,
    }
}