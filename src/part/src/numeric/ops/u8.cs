//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Numeric
    {

        [MethodImpl(Inline), Op]
        public static byte u8(byte src)
            => src;

        [MethodImpl(Inline), Op]
        public static ushort u16(ushort src)
            => src;
    }
}