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
    
    using static Root;

    partial class SystemCollections
    {    
        public static void Include<T>(this ISet<T> dst, IEnumerable<T> src )
            => iter(src, item => dst.Add(item));
        
        public static void Include<T>(this ISet<T> dst, params T[] src)
            => iter(src, item => dst.Add(item));
    }

}