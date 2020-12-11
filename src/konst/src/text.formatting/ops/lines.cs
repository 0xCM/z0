//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Collections.Generic;

    using static Part;
    using static z;

    partial struct Render
    {
        [MethodImpl(Inline), Op]
        public static void lines<F>(IEnumerable<F> src, StringBuilder dst)
            where F : ITextual
                => dst.Lines(Render.format(src));

        [MethodImpl(Inline), Op]
        public static void lines(IEnumerable<string> src, StringBuilder dst)
            => iter(src, line =>  dst.AppendLine(line));
    }
}