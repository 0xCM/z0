//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static System.StringSplitOptions;

    partial struct TextTools
    {
        [Op]
        public static ReadOnlySpan<string> split(string src, char sep, bool clean = true)
            => src.Split(sep,  clean ? RemoveEmptyEntries : None);

        [Op]
        public static ReadOnlySpan<string> split(string src, string sep, bool clean = true)
            => src.Split(sep, clean ? RemoveEmptyEntries : None);
    }
}