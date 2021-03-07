//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Digital
    {
        /// <summary>
        /// Converts a character in the inclusive range [0,1] to the corresponding number in the same range
        /// </summary>
        /// <param name="c">The digit character</param>
        [MethodImpl(Inline), Op]
        public static byte u8(Base2 @base, char c)
            => (byte)digit(@base, c);

        /// <summary>
        /// Converts a character in the inclusive range [0,9] to the corresponding number in the same range
        /// </summary>
        /// <param name="c">The digit character</param>
        [MethodImpl(Inline), Op]
        public static byte u8(Base10 @base, char c)
            => (byte)digit(@base, c);

        /// <summary>
        /// Converts a character in the inclusive range [0,7] to the corresponding number in the same range
        /// </summary>
        /// <param name="c">The digit character</param>
        [MethodImpl(Inline), Op]
        public static byte u8(Base8 @base, char c)
            => (byte)digit(@base, c);
    }
}