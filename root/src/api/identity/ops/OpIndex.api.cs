//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    public static class OpIndex
    {        
        public static OpIndex<T> From<T>(IEnumerable<(OpIdentity,T)> src, bool deduplicate = true)
                => new OpIndex<T>(src, deduplicate);

        public static OpIndex<T> ToOpIndex<T>(this IEnumerable<(OpIdentity,T)> src, bool deduplicate = true)
            => new OpIndex<T>(src, deduplicate);

        public static OpIndex<Paired<L,R>> Intersect<L,R>(this IOpIndex<L> left, IOpIndex<R> right)
        {
             var keys = left.Keys.ToHashSet();
             keys.IntersectWith(right.Keys);
             var keylist = keys.ToArray();
             var count = keylist.Length;
             var entries = Arrays.alloc<(OpIdentity,Paired<L,R>)>(count);
             for(var i=0; i<count; i++)
             {
                var key = keylist[i];
                entries[i] = (key, (left[key], right[key]));
             }
             return entries.ToOpIndex();
         }   
    }
}