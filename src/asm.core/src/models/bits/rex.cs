//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using SR = SymbolicRender;

    partial class AsmBits
    {
        [MethodImpl(Inline), Op]
        public static uint rex(RexPrefix src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            BitRender.render8x4(src.Encoded, ref  i, dst);
            return i-i0;
        }

        const string RexBitstring = "0100 {0} {1} {2} {3}";

        const string RexHeader = "Marker {0,-3} {1,-3} {2,-3} {3,-3}";

        [Op]
        public static string bitstring(RexPrefix src)
            => string.Format(RexBitstring, src.W(), src.R(), src.X(), src.B());
    }
}