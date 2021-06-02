//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;
    using static core;

    partial struct BitRender
    {
        [MethodImpl(Inline), Closures(Closure)]
        public static BitFormatter<T> formatter<T>(BitFormat? config = null)
            where T : struct
                => new BitFormatter<T>(config ?? BitFormat.configure());
    }
}