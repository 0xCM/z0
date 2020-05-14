//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static refs;
    using static HexSpecs;

    partial class Hex
    {
        
        [MethodImpl(Inline), Op]
        public static char digit(byte value)
            => (char)skip(in head(Uppercase), 0xF & value);

        [MethodImpl(Inline), Op]
        public static char digit(byte value, int pos)
            => (char)skip(in head(Uppercase), 0xF & (byte)(value >> pos*4));

        [MethodImpl(Inline), Op]
        public static char digit(ushort value, int pos)
            => (char)skip(in head(Uppercase), 0xF & (byte)(value >> pos*4));

        [MethodImpl(Inline), Op]
        public static char digit(uint value, int pos)
            => (char)skip(in head(Uppercase), 0xF & (byte)(value >> pos*4));

        [MethodImpl(Inline), Op]
        public static char digit(ulong value, int pos)
            => (char)skip(in head(Uppercase), 0xF & (byte)(value >> pos*4));

    }
}