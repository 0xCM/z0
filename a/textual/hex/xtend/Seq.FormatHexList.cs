//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Textual;
    
    partial class XTend
    {

        /// <summary>
        /// Formats a scalar stream as a hex string
        /// </summary>
        /// <param name="src">The source bytes</param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        public static string FormatHexList(this IEnumerable<byte> src, bool zpad = true, bool specifier = true, 
            bool uppercase = false, bool prespec = true)
                => text.bracket(src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec)).Select(x => x.ToString()).Concat(Chars.Comma));
    }
}