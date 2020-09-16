//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct TextBuffers
    {
        [MethodImpl(Inline), Op]
        public static DynamicTextBuffer dynamic()
            => new DynamicTextBuffer(text.build());

        [MethodImpl(Inline), Op]
        public static DynamicTextBuffer dynamic(StringBuilder dst)
            => new DynamicTextBuffer(dst);

    }
}