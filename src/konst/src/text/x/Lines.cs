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
            => TextFormatter.lines(src,dst);
    }
}