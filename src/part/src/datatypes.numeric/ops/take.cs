//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Numeric
    {
        [MethodImpl(Inline), Op]
        public static ushort take16u(ReadOnlySpan<byte> src)
        {
            var len = src.Length;
            if(len >= 2)
                return first16(src);
            else if(len > 0)
                return first(src);
            else
                return 0;
        }

        [MethodImpl(Inline), Op]
        public static uint take32u(ReadOnlySpan<byte> src)
        {
            var len = src.Length;
            if(len >= 4)
                return first32(src);
            else
                return take16u(src);
        }

        [MethodImpl(Inline), Op]
        public static ulong take64u(ReadOnlySpan<byte> src)
        {
            var len = src.Length;
            if(len >= 8)
                return first64(src);
            else
                return take32u(src);
        }
    }
}