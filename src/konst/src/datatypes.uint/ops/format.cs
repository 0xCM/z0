//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using U = uint2;

    partial struct UI
    {
        static BitFormat FormatConfig2
            => BitFormatter.limited(U.Width, U.Width);

        [MethodImpl(Inline), Op]
        public static string format(uint2 src)
            => BitFormatter.format(src.data, FormatConfig2);
    }
}