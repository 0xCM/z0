//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    [ApiHost]
    public readonly partial struct AsmPrefixTest
    {
        [MethodImpl(Inline), Op]
        public static bit rex(uint src)
            => (byte)src & 0x40;

        [MethodImpl(Inline), Op]
        public static bit vex(uint src)
            => (byte)src == 0xC4 || (byte)src == 0xC5;

        [MethodImpl(Inline), Op]
        public static bit evex(uint src)
            => (byte)src == 0x62;
    }
}