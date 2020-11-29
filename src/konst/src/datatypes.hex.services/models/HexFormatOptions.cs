//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a common set of hex formatting options
    /// </summary>
    public struct HexFormatOptions
    {
        /// <summary>
        /// Indicates whether the numeric content should be left-padded with zeros
        /// </summary>
        public bool ZPad;

        /// <summary>
        /// Indicates whether a hex specifier, either prefixing or suffixing the numeric content, should be emitted
        /// </summary>
        public bool Specifier;

        /// <summary>
        /// Indicates whether the hex digits 'A',..,'F' should be upper-cased
        /// </summary>
        public bool Uppercase;

        /// <summary>
        /// Indicates whether the hex numeric specifier, if emitted, prefix the output
        /// </summary>
        public bool PreSpec;

        /// <summary>
        /// The case format character, either 'X' or 'x'
        /// </summary>
        public char CaseFormatChar;

        /// <summary>
        /// The character with which to intersperse hex number sequences
        /// </summary>
        public char Delimiter;

        /// <summary>
        /// The hex format string as determined by configuration
        /// </summary>
        public string FormatCode
            => $"{CaseFormatChar}";


        [MethodImpl(Inline)]
        public HexFormatOptions(bool zpad, bool specifier, bool uppercase, bool prespec, char delimiter)
        {
            ZPad = zpad;
            Specifier = specifier;
            Uppercase = uppercase;
            PreSpec = prespec;
            CaseFormatChar = HexFormatSpecs.CaseSpec(uppercase);
            Delimiter = delimiter;
        }

        [MethodImpl(Inline)]
        public static implicit operator HexSeqFormat(in HexFormatOptions src)
            => HexFormatSpecs.seq(src);
    }
}