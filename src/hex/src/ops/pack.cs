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

    partial struct Hex
    {
        [MethodImpl(Inline), Op]
        public static byte pack(HexDigitValue d0, HexDigitValue d1)
            => (byte)((uint)d0 | ((uint)d1) << 4);

        [MethodImpl(Inline), Op]
        public static uint pack(ReadOnlySpan<HexDigitValue> src, Span<byte> dst)
        {
            var count = src.Length;
            var j=0u;
            if(dst.Length >= count/2 && count % 2 == 0)
            {
                for(var i=0; i<count; i+=2)
                {
                    ref readonly var d0 = ref skip(src,i+1);
                    ref readonly var d1 = ref skip(src,i);
                    seek(dst,j++) = pack(d0,d1);
                }
            }
            return j;
        }
    }
}