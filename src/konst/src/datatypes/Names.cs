//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Names
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static NamedValue<V> value<V>(string name, V value)
            => new NamedValue<V>(name, value);

        [MethodImpl(Inline), Op]
        public static int compare(in Name a, in Name b)
            => compare(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static int compare(string a, string b)
        {
            var result = 0;
            ref readonly var x = ref first(a);
            ref readonly var y = ref first(b);
            var count = min(a.Length, b.Length);
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

        [MethodImpl(Inline), Op]
        static unsafe int compare_alt(in Name x, in Name y)
        {
            var result = 0;
            var count = min(x.Count, y.Count);
            var pX = x.Address.Pointer<char>();
            var pY = y.Address.Pointer<char>();
            for(var i = 0u; i<count; i++, pX++, pY++)
            {
                var cx = *pX;
                var cy = *pY;
                if(cx == cy)
                    continue;
                else
                    return cx.CompareTo(cy);
            }
            return result;
        }
    }
}