//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;

    partial struct AsmAlgorithms
    {
        [Op, Closures(Closure)]
        public static string format<T>(Section<T> src)
            => Format.enclose(Format.adjacent(src.Max, SectionDelimiter, src.Min), SectionFence);
    }
}