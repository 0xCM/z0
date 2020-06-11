//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Control;
    using static Typed;

    partial class AsciCodes
    {
        /// <summary>
        /// Populates a 2-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci2 encode(N2 n, ReadOnlySpan<char> src)
            => encode(src, out asci2 dst);

        /// <summary>
        /// Populates a 4-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci4 encode(N4 n, ReadOnlySpan<char> src)
            => encode(src, out asci4 dst);

        [MethodImpl(Inline), Op]
        public static asci5 encode(N5 n, ReadOnlySpan<char> src)
        {
            var dst = 0ul;
            ref readonly var src16 = ref head(src);
            ref var dst8 = ref imagine<ulong,byte>(ref dst);
            seek(ref dst8, 0) = (byte)skip(src16, 0);
            seek(ref dst8, 1) = (byte)skip(src16, 1);
            seek(ref dst8, 2) = (byte)skip(src16, 2);
            seek(ref dst8, 3) = (byte)skip(src16, 3);
            seek(ref dst8, 4) = (byte)skip(src16, 4);
            return AsciCodes.define(n5,dst);
        }
    
        /// <summary>
        /// Populates an 8-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci8 encode(N8 n, ReadOnlySpan<char> src)
            => encode(src, out asci8 dst);

        /// <summary>
        /// Populates a 16-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci16 encode(N16 n, ReadOnlySpan<char> src)
            => encode(src, out asci16 dst);

        /// <summary>
        /// Populates a 32-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci32 encode(N32 n, ReadOnlySpan<char> src)
            => encode(src, out asci32 dst);

        /// <summary>
        /// Populates a 32-code asci block from the leading cells of a character span
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static asci64 encode(N64 n, ReadOnlySpan<char> src)
            => encode(src, out asci64 dst);
    }
}