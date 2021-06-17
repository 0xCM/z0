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

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static uint length(StringAddress src)
        {
            ref var c = ref firstchar(src);
            var counter = 0u;
            while(c != 0)
                c = seek(c, counter++);
            return counter - 1;
        }
    }
}