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


    partial class text
    {
        [Op]
        public static int index(ReadOnlySpan<char> src, char match)
            => TextTools.index(src, match);

        [Op]
        public static int index(ReadOnlySpan<char> src, ReadOnlySpan<char> match)
            => TextTools.index(src, match);

        [Op]
        public static int index(string src, char match)
            => TextTools.index(src, match);
    }
}