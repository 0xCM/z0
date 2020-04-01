//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XTend
    {
        /// <summary>
        /// Formtas an array of bytes as a hex string
        /// </summary>
        /// <param name="src">The source bytes</param>
        /// <param name="sep"></param>
        /// <param name="zpad">Specifies whether each value should be left-padded with zeros commensurate with size of the data type </param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        /// <param name="segwidth">The maximum number of bytes on a single line</param>
        public static string FormatHex(this byte[] src, char sep, bool zpad = true, bool specifier = true, 
            bool uppercase = false, bool prespec = true, int? segwidth = null)
                => src.ToReadOnlySpan().FormatHexBytes(sep, zpad, specifier, uppercase, prespec, segwidth);

        public static string FormatHex(this byte[] src, char sep = Chars.Space)
            => src.AsSpan().ReadOnly().FormatHex(sep);
    }
}