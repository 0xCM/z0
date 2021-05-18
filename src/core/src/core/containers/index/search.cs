//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Index
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool search<T>(T[] src, Func<T,bool> predicate, out T found)
        {
            var view = @readonly(src);
            var count = view.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var candidate = ref skip(view,i);
                if(predicate(candidate))
                {
                    found = candidate;
                    return true;
                }
            }
            found = default;
            return false;
        }
    }
}