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

    partial class Hex
    {
        /// <summary>
        /// Returns the hex character code for a <see cref='uint4'/> value
        /// </summary>
        /// <param name="src">The value to be hex-encoded</param>
        [MethodImpl(Inline), Op]
        public static HexCodeUp code(UpperCased upper, uint4 src)
            => (HexCodeUp)skip(first(UpperHexDigits), src);

        /// <summary>
        /// Returns the hex character code for a <see cref='uint4'/> value
        /// </summary>
        /// <param name="src">The value to be hex-encoded</param>
        [MethodImpl(Inline), Op]
        public static HexCodeLo code(LowerCased lower, uint4 src)
            => (HexCodeLo)skip(first(LowerHexDigits), src);
    }
}