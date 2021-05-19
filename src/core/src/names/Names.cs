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

    [ApiHost]
    public readonly struct Names
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static NamedValue<V> value<V>(string name, V value)
            => new NamedValue<V>(name, value);

        [MethodImpl(Inline), Op]
        public static int compare(Name a, Name b)
            => compare(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static int compare(string a, string b)
        {
            if(a == null || b == null)
                return 0;

            var result = 0;
            ref readonly var x = ref first(a);
            ref readonly var y = ref first(b);
            var count = Math.Min(a.Length, b.Length);
            for(var i=0u; i<count; i++)
            {
                ref readonly var cx = ref skip(x, i);
                ref readonly var cy = ref skip(y, i);
                if(cx == cy)
                    continue;
                else
                    return cx.CompareTo(cy);
            }
            return result;
        }
    }
}