// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    partial class RootCollections
    {
        public static ISet<T> Intersection<T>(this ISet<T> s1, ISet<T> s2)
        {
            var dst = new HashSet<T>(s1);
            dst.IntersectWith(s2);
            return dst;        
        }
    }
}