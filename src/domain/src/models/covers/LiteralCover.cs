//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct LiteralCover
    {
        public ValueType Cover {get;}
        
        public FieldInfo[] Covered {get;}
        
        [MethodImpl(Inline)]
        public LiteralCover(ValueType cover, FieldInfo[] covered)
        {
            Cover = cover;
            Covered = covered;
        }    
    }
}