//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Textual;

    public static class BitFormatting
    {
        [MethodImpl(Inline)]
        static BitFormatter<T> BitFormatter<T>()
            where T : struct
                => default;

        /// <summary>
        /// Formats source bits using default configuration
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <typeparam name="T">The bit source type</typeparam>
        public static string FormatDataBits<T>(this T src)
            where T : struct
                => BitFormatter<T>().Format(src);

        /// <summary>
        /// Formats source bits using a specified configuration
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="config">The formatting configuration</param>
        /// <typeparam name="T">The bit source type</typeparam>
        public static string FormatDataBits<T>(this T src, in BitFormatConfig config)
            where T : struct
                => BitFormatter<T>().Format(src,config);
    }
}