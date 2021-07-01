//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    [ApiHost]
    public readonly partial struct IntelSdm
    {
        [MethodImpl(Inline), Op]
        public static TableNumber table(ReadOnlySpan<char> src)
            => new TableNumber(src);

        [MethodImpl(Inline), Op]
        public static VolNumber vol(byte major, char minor)
            => new VolNumber(major, (AsciCode)minor);

        [MethodImpl(Inline), Op]
        public static Placeholder placeholder(char a, char b, byte count)
            => new Placeholder(a,b,count);
    }
}