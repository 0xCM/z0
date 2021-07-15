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

    partial struct LookupTables
    {
        [Op]
        public static string format(LookupKey key)
        {
            const string Pattern = "({0},{1})";
            return string.Format(Pattern, key.Row(), key.Col());
        }

        [Op, Closures(Closure)]
        public static string format<T>(KeyMap<T> src)
        {
            const string Pattern = "({0},{1}) -> {2}";
            return string.Format(Pattern, src.Key.Row(), src.Key.Col(), src.Target);
        }
    }
}