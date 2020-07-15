//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct CrossMap
    {
        static ReadOnlySpan<byte> Bad8u
            => new byte[2]{
                0x00, 0x10
                };

        static ReadOnlySpan<ushort> Bad16u
        {
            [MethodImpl(Inline), Op]
            get => Bad8u.Cast<ushort>();
        }

        static ReadOnlySpan<byte> Good8u
            => new byte[2]{
                0x00, 0x10
                };

        static ReadOnlySpan<ushort> Good16u
        {
            [MethodImpl(Inline), Op]
            get => Good8u.Cast<ushort>();
        }

        [MethodImpl(Inline), Op]
        public static char replace(ushort c)
            => (char)(c == skip(Bad16u,0) ? skip(Good16u,0) : c);


    }
}