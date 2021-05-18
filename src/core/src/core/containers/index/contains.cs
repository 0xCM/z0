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
        public static bool contains<T>(Index<T> src, T match)
        {
            var count = src.Count;
            ref var source = ref src.First;
            for(var i=0; i<count; i++)
                if(skip(source, i).Equals(match))
                    return true;
            return false;
        }
    }
}