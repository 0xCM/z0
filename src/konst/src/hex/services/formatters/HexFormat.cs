//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static core;

    [ApiHost]
    public static class HexFormat
    {
        [MethodImpl(Inline)]
        public static HexFormatter<T> formatter<T>()
            where T : unmanaged
                => new HexFormatter<T>(SystemHexFormatters.create<T>());

        [MethodImpl(Inline), Op]
        public static HexFormatConfig configure(bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true, char? delimiter = null)
            => new HexFormatConfig(zpad,specifier,uppercase,prespec, delimiter ?? Chars.Comma);

        /// <summary>
        /// Formats a numeric array as hex data content
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static string format<T>(T[] src)
            where T : unmanaged
                => HexFormat.formatter<T>().Format(src, HexFormatConfig.HexData);

        /// <summary>
        /// Formats a numeric array as hex data
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static string data<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => formatter<T>().Format(src, HexFormatConfig.HexData);

   }
}