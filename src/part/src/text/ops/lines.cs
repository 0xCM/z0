//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static TextRules;

    partial class text
    {
        [Op]
        public static Index<TextLine> lines(string src)
            => Parse.lines(src);
    }
}