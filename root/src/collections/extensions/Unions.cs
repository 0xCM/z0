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

    partial class RootCollections
    {  
        public static ISet<T> Unions<T>(this ISet<T> a, params ISet<T>[]  sets)
        {
            for(var i=0; i<sets.Length; i++)
            foreach(var item in sets[i])
                a.Add(item);
            return a;
        }
    }
}