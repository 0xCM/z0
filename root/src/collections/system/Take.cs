// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    partial class SystemCollections
    {
        public static IEnumerable<S> TakeAtMost<S>(this IEnumerable<S> src, int count)
        {
            var i = 0;
            var it = src.GetEnumerator();
            while(it.MoveNext() && i++ < count)
                yield return it.Current;        
        }
    }
}