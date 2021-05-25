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
    using static Widths;

    partial struct HexFormat
    {
        [MethodImpl(Inline), Op]
        public static string format<W,T>(T value, W w = default, bool postspec = false)
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W8))
                return HexFormatter.format(w8, bw8(value), postspec);
            else if(typeof(W) == typeof(W16))
                return HexFormatter.format(w16, bw16(value), postspec);
            else if(typeof(W) == typeof(W32))
                return HexFormatter.format(w32, bw32(value), postspec);
            else
                return HexFormatter.format(w64, bw64(value), postspec);
        }

    }
}