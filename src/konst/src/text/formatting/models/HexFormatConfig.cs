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
    public readonly struct HexFormatConfig
    {
        /// <summary>
        /// Indicates whether the numeric content should be left-padded with zeros
        /// </summary>
        public readonly bool ZPad;

        /// <summary>
        /// Indicates whether a hex specifier, either prefixing or suffixing the numeric content, should be emitted
        /// </summary>
        public readonly bool Specifier;

        /// <summary>
        /// Indicates whether the hex digits 'A',..,'F' should be upper-cased
        /// </summary>
        public readonly bool Uppercase;

        /// <summary>
        /// Indicates whether the hex numeric specifier, if emitted, shold prefix the output
        /// </summary>
        public readonly bool PreSpec;

        /// <summary>
        /// The case format character, either 'X' or 'x'
        /// </summary>
        public readonly char CaseFormatChar;

        /// <summary>
        /// The character with which to intersperse hex number sequences
        /// </summary>
        public readonly char Delimiter;

        /// <summary>
        /// The hex format string as determined by configuration
        /// </summary>
        public string FormatCode
            => $"{CaseFormatChar}";

        /// <summary>
        /// Specifies the default configuration for hex data emission
        /// </summary>
        public static HexFormatConfig HexData
            => new HexFormatConfig(true, false, false, false, Space);

        /// <summary>
        /// The default configuration for array initialization content
        /// </summary>
        public static HexFormatConfig ArrayContent
            => new HexFormatConfig(true, true, false, true, Chars.Comma);

        [MethodImpl(Inline)]
        public static implicit operator HexSeqFormat(in HexFormatConfig src)
            => HexSeqFormat.define(src);

        [MethodImpl(Inline)]
        public HexFormatConfig(bool zpad, bool specifier, bool uppercase, bool prespec, char delimiter)
        {
            ZPad = zpad;
            Specifier = specifier;
            Uppercase = uppercase;
            PreSpec = prespec;
            CaseFormatChar = HexFormatSpecs.CaseSpec(uppercase);
            Delimiter = delimiter;
        }
    }
}