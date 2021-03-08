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
        /// Retrieves the character corresponding to a specified <see cref='HexDigit'/>
        /// </summary>
        /// <param name="case">The case specifier</param>
        /// <param name="value">The digit value</param>
        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, HexDigit value)
            => value == HexDigit.None ? Chars.Null : (char)symbol(@case, value);
    }
}