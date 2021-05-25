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
    using static HexFormatSpecs;

    partial struct Hex
    {

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, byte value, byte pos)
            => (char)skip(first(LowerHexDigits), (byte)(0xF & (byte)(value >> pos*4)));


        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, byte value, byte pos)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

    }
}