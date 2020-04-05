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

    [ApiHost]
    public static partial class Hex
    {
        [MethodImpl(Inline)]
        public static HexFormatter<T> formatter<T>()
            where T : unmanaged
                => new HexFormatter<T>(SystemHexFormatters.Create<T>());                   

        /// <summary>
        /// Returns the hex character code for a number in the interval [0,15]
        /// </summary>
        /// <param name="value">The value to be hex-encoded</param>
        [MethodImpl(Inline), Op]
        public static byte code(byte value)
            => skip(in head(Uppercase), value & 0xf);

        [MethodImpl(Inline), Op]
        public static bool test(char c)
            => HexSpecs.IsHex(c);

        [MethodImpl(Inline), Op]
        public static void digits(byte value, out char d0, out char d1)
        {
            ref readonly var codes = ref head(Uppercase);
            d0 = (char)skip(in codes, 0xF & value);
            d1 = (char)skip(in codes, (value >> 4) & 0xF);
        }

    }
}