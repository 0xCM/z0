//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static HexCharData;

    partial struct Hex
    {
        /// <summary>
        /// Returns the hex character code for a specified value of at most 4 bits
        /// </summary>
        /// <param name="src">The value to be hex-encoded</param>
        [MethodImpl(Inline), Op]
        public static HexCodeUp code(N4 n, UpperCased upper, byte src)
            => (HexCodeUp)skip(first(UpperHexDigits), src);

        /// <summary>
        /// Returns the hex character code for a <see cref='uint4'/> value
        /// </summary>
        /// <param name="src">The value to be hex-encoded</param>
        [MethodImpl(Inline), Op]
        public static HexCodeLo code(N4 n, LowerCased lower, byte src)
            => (HexCodeLo)skip(first(LowerHexDigits), src);
    }
}