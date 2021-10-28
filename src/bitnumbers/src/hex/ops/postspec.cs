//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static HexFormatSpecs;
    using static core;

    partial struct Hex
    {
        [MethodImpl(Inline), Op]
        public static uint postspec(ref uint i, Span<char> dst)
        {
            seek(dst,i++) = PostSpecChar;
            return 2;
        }
    }
}