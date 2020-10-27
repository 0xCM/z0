//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    
    partial struct Arrays
    {            
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] from<T>(IEnumerable<T> src)
            => src.Array();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] from<T>(params T[] src)
            => src;
    }
}