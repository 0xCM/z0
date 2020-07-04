//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
            
    public readonly struct PartBox
    {
        
        [MethodImpl(Inline)]
        public PartBox(object src)
            => Boxed = src;
        
        public readonly object Boxed;

        public static PartBox Empty 
            => new PartBox((sbyte)-1);        
    }
}