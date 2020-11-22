//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct Render
    {
        /// <summary>
        /// Renders a primal numeric value as hex-formatted text
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="zpad">Specifies whether the output should be 0-padded to the data type width</param>
        /// <param name="specifier">Specifies whether the output should be prefixed/postfixed with a hex specifier</param>
        /// <param name="uppercase">Specifies whether the alphabetic hex digits should be uppercased</param>
        /// <param name="prespec">Specifies whether the hex specifier, if emitted, should be the canonical prefix or postfix specifier</param>
        /// <typeparam name="T">The primal numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string hex<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
                => Hex.format(src,zpad, specifier, uppercase,prespec);
    }
}