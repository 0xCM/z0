//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    partial class XTend
    {
        public static void Lines(this StringBuilder dst, IEnumerable<string> src)
        {
            foreach(var line in src)
                dst.AppendLine(line);            
        }

        public static void Lines<F>(this StringBuilder src, IEnumerable<F> items)
            where F : ITextual
                => src.Lines(text.items(items));
    }
}