//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asci
    {
        /// <summary>
        /// Populates a 2-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci2 encode(N2 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci2 dst);

        /// <summary>
        /// Populates a 4-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci4 encode(N4 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci4 dst);

        /// <summary>
        /// Populates an 8-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci8 encode(N8 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci8 dst);

        /// <summary>
        /// Populates a 16-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci16 encode(N16 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci16 dst);

        /// <summary>
        /// Populates a 32-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci32 encode(N32 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci32 dst);

        /// <summary>
        /// Populates a 32-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci64 encode(N64 n, ReadOnlySpan<char> src)
            => asci.encode(src, out asci64 dst);
    }
}