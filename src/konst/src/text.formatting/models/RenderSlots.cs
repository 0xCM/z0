//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct FormatSlots
    {
        const string N0x16 = "{0,-16}";

        const string N1x16 = "{1,-16}";

        const string N2x16 = "{2,-16}";

        [MethodImpl(Inline), Op]
        public static RenderPattern rpad(N0 pos, N16 width)
            => new RenderPattern(N0x16);

        [MethodImpl(Inline), Op]
        public static RenderPattern rpad(N1 pos, N16 width)
            => new RenderPattern(N1x16);

        [MethodImpl(Inline), Op]
        public static RenderPattern rpad(N2 pos, N16 width)
            => new RenderPattern(N2x16);
    }
}