//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct TextTools
    {
        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, int offset)
            => RP.substring(src, offset);

        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, int offset, int length)
            => RP.substring(src, offset, length);

        /// <summary>
        /// Extracts a substring beginning at a specified offset
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, uint offset)
            => RP.substring(src, (int)offset);

        /// <summary>
        /// Extracts a substring of specified length beginning at a specified offset
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="offset">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, uint offset, uint length)
            => RP.substring(src,(int)offset, (int)length);
    }
}